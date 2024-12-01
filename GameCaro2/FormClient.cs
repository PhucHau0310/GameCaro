using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GameCaro2.ChessBoardManager;

namespace GameCaro2
{
    public partial class FormClient : Form
    {
        private ChessBoardManager ChessBoard;
        private SocketManager socket;
        private int xPosition;

        public FormClient()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            InitializeComponent();

            InitializeHorizontalScrollingText();

            ChessBoard = new ChessBoardManager(pnlChessBoard, currentPlayerName, ptcBoxCurrentPlayer);
            //ChessBoard.CurrentPlayer = 1;

            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            ChessBoard.EndedGame += ChessBoard_EndedGame;

            socket = new SocketManager();

            // Setup timer for game
            pcbCoolDown.Step = Constain.COOL_DOWN_STEP;
            pcbCoolDown.Maximum = Constain.COOL_DOWN_TIME;
            pcbCoolDown.Value = 0;

            tmCoolDown.Interval = Constain.COOL_DOWN_INTERVAL;

            NewGame();

            // Initialize as not server
            socket.isServer = false;
            pnlChessBoard.Enabled = false;
        }
        private void InitializeHorizontalScrollingText()
        {
            lblScrollTextHorizontal.Text = "Trò chơi Caro - 5 ô liên tiếp sẽ chiến thắng ^_^";
            lblScrollTextHorizontal.AutoSize = true;

            // Bắt đầu từ ngoài bên trái của Panel
            xPosition = -lblScrollTextHorizontal.Width;

            timerScrollHorizontal.Interval = 35; // Tốc độ cuộn (ms)
            timerScrollHorizontal.Tick += TimerScrollHorizontal_Tick; // Liên kết sự kiện Timer
            timerScrollHorizontal.Start();
        }

        private void TimerScrollHorizontal_Tick(object sender, EventArgs e)
        {
            // Di chuyển label sang phải
            xPosition += 2; // Tăng giá trị để di chuyển sang phải
            lblScrollTextHorizontal.Location = new System.Drawing.Point(xPosition, lblScrollTextHorizontal.Location.Y);

            // Nếu label đã di chuyển hết khỏi Panel, đưa nó về lại bên trái
            if (xPosition > pnlTextScrollHorizontal.Width)
            {
                xPosition = -lblScrollTextHorizontal.Width;
            }
        }

        //void NewGame()
        //{
        //    pcbCoolDown.Value = 0;
        //    tmCoolDown.Stop();
        //    btnUndo.Enabled = true;

        //    ChessBoard.DrawChessBoard();
        //    socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
        //}

        void NewGame(bool isFromSocket = false)
        {
            // Reset trạng thái game
            pcbCoolDown.Value = 0;
            tmCoolDown.Stop();
            btnUndo.Enabled = true;

            // Vẽ lại bàn cờ
            ChessBoard.DrawChessBoard();

            // Nếu không phải từ Socket, gửi lệnh NEW_GAME
            if (!isFromSocket)
            {
                socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            }
        }


        void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            btnUndo.Enabled = false;
        }

        void Undo()
        {
            ChessBoard.Undo();
            pcbCoolDown.Value = 0;
        }

        void Quit()
        {
            Application.Exit();
        }

        private void ChessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            tmCoolDown.Start();
            pnlChessBoard.Enabled = false;
            pcbCoolDown.Value = 0;

            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));

            btnUndo.Enabled = false;
            Listen();
        }

        private void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();

                    ProcessData(data);
                }
                catch { }
            });

            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        //NewGame();
                        NewGame(isFromSocket: true);
                        pnlChessBoard.Enabled = true;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        pcbCoolDown.Value = 0;
                        pnlChessBoard.Enabled = true;
                        tmCoolDown.Start();
                        ChessBoard.OtherPlayerMark(data.Point);
                        btnUndo.Enabled = true;
                    }));
                    break;
                case (int)SocketCommand.SEND_MESSAGE:
                    txtBoxChat.Text = data.Message;
                    break;
                case (int)SocketCommand.UNDO:
                    Undo();
                    pcbCoolDown.Value = 0;
                    break;
                case (int)SocketCommand.END_GAME:
                    string winnerName = ChessBoard.Player[ChessBoard.CurrentPlayer].Name;
                    MessageBox.Show($"{winnerName} đã chiến thắng!");
                    break;
                case (int)SocketCommand.TIME_OUT:
                    MessageBox.Show("Hết thời gian!");
                    break;
                case (int)SocketCommand.QUIT:
                    tmCoolDown.Stop();
                    MessageBox.Show("Player disconnected");
                    break;
            }

            Listen();
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            pcbCoolDown.PerformStep();

            if (pcbCoolDown.Value >= pcbCoolDown.Maximum)
            {
                EndGame();
                socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
            }
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            socket.IP = txtBoxClient.Text;
            if (socket.ConnectServer())
            {
                Thread listenThread = new Thread(() =>
                {
                    socket.Send(new SocketData((int)SocketCommand.NOTIFY, "Client connected!", new Point()));
                    //EnableClientChessBoard(); // Khi kết nối, set symbol cho client
                    Listen();
                });
                listenThread.IsBackground = true;
                listenThread.Start();

                socket.Send(new SocketData((int)SocketCommand.NOTIFY, "Client connected!", new Point()));
                lblClient.Text = "Kết nối thành công";
                currentPlayerName.Text = ChessBoard.Player[0].Name;

                ptcBoxCurrentPlayer.BackgroundImage = ChessBoard.Player[0].Mark;
                ptcBoxCurrentPlayer.BackgroundImage = ChessBoard.Player[1].Mark;
            }
            else
            {
                MessageBox.Show("Cannot connect to server!");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewGame();
            pnlChessBoard.Enabled = true;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void FormClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon thoat ?", "Thong Bao", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                    socket.Close(); ;
                }
                catch
                {

                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtBoxChat.Text += "- " + "Caesar" + ": " + txtBoxMessage.Text + "\r\n";
            txtBoxMessage.Text = "";

            socket.Send(new SocketData((int)SocketCommand.SEND_MESSAGE, txtBoxChat.Text, new Point()));
            Listen();
        }

        private void txtBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxChat.Text += "- " + "Caesar" + ": " + txtBoxMessage.Text + "\r\n";
                txtBoxMessage.Text = "";

                socket.Send(new SocketData((int)SocketCommand.SEND_MESSAGE, txtBoxChat.Text, new Point()));
                Listen();
            }
               
        }
    }
}
