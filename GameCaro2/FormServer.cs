using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GameCaro2.ChessBoardManager;

namespace GameCaro2
{
    public partial class FormServer : Form
    {
        private ChessBoardManager ChessBoard;
        private SocketManager socket;
        public Label lblSer;
        private int yPosition;
        SqlCommand cmd;
        SqlDataAdapter adt;
        Db db;

        public FormServer()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            InitializeComponent();

            // About
            InitializeScrollingText();

            ChessBoard = new ChessBoardManager(pnlChessBoard, currentPlayerName, ptcBoxCurrentPlayer);
            //ChessBoard.CurrentPlayer = 0;

            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            ChessBoard.EndedGame += ChessBoard_EndedGame;

            socket = new SocketManager();

            // Setup timer for game
            pcbCoolDown.Step = Constain.COOL_DOWN_STEP;
            pcbCoolDown.Maximum = Constain.COOL_DOWN_TIME;
            pcbCoolDown.Value = 0;

            tmCoolDown.Interval = Constain.COOL_DOWN_INTERVAL;

            NewGame();

            // Initialize as server
            socket.isServer = true;
            pnlChessBoard.Enabled = false;
        }

        private void InitializeScrollingText()
        {
            lblScrollText.Text = "     Trò chơi Caro ^_^ \n" + 
                                 "        Winforms C# \n" +
                                 " ----- ♦ ♦ ♦ ----- \n" + 
                                 "            Nhóm 5: \n" +
                                 " Nguyyễn Phúc Hậu \n" +
                                 " Vạn Tường Caesar \n" +
                                 " Nguyễn Phi Phụng \n" +
                                 " Nguyễn Nhật Băng \n" +
                                 " Đinh Văn Khoa \n" +
                                 " Ban Ngọc Tuấn \n";


            lblScrollText.AutoSize = true;
            yPosition = pnlTextScroll.Height; // Bắt đầu từ vị trí dưới cùng của Panel

            timerScroll.Interval = 35; // Tốc độ cuộn (ms)
            timerScroll.Tick += TimerScroll_Tick; // Liên kết sự kiện Timer
            timerScroll.Start();
        }

        private void TimerScroll_Tick(object sender, EventArgs e)
        {
            // Di chuyển label lên trên
            yPosition -= 2; // Tăng giá trị âm để di chuyển lên
            lblScrollText.Location = new System.Drawing.Point(lblScrollText.Location.X, yPosition);

            // Nếu label đã di chuyển hết khỏi Panel, đưa nó về lại bên dưới
            if (yPosition + lblScrollText.Height < 0)
            {
                yPosition = pnlTextScroll.Height;
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

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
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

        private void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();

                    ProcessData(data);
                }
                catch(Exception ex) {
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    }));
                }
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
                    db = new Db();
                    string winnerName = ChessBoard.Player[ChessBoard.CurrentPlayer].Name;
                    string opponentName = ChessBoard.Player[ChessBoard.CurrentPlayer == 1 ? 0 : 1].Name;

                    try
                    {
                        db.con.Open();

                        // Tạo truy vấn INSERT để lưu lịch sử đấu
                        string query = "INSERT INTO GameHistory (Player1Name, Player2Name, WinnerName, GameMode) VALUES (@Player1Name, @Player2Name, @WinnerName, @GameMode)";
                        cmd = new SqlCommand(query, db.con);

                        // Thêm tham số vào truy vấn
                        cmd.Parameters.AddWithValue("@Player1Name", winnerName);
                        cmd.Parameters.AddWithValue("@Player2Name", opponentName);
                        cmd.Parameters.AddWithValue("@WinnerName", winnerName);
                        cmd.Parameters.AddWithValue("@GameMode", "1 vs 1");

                        cmd.ExecuteNonQuery(); // Thực thi truy vấn

                        db.con.Close();

                        // Thông báo người chiến thắng
                        MessageBox.Show($"{winnerName} đã chiến thắng!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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


        private void btnServer_Click(object sender, EventArgs e)
        {
            socket.IP = lblIP.Text;
            lblServer.Text = "Đã khởi tạo phòng";
            socket.CreateServer();
            pnlChessBoard.Enabled = true;

            Thread listenThread = new Thread(() =>
            {
                Listen();
            });

            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
            pnlChessBoard.Enabled = true;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void FormServer_FormClosing_1(object sender, FormClosingEventArgs e)
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
                    socket.Close();
                }
                catch
                {

                }
            }
        }

        private void FormServer_Shown(object sender, EventArgs e)
        {
            lblIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(lblServer.Text))
            {
                lblIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtBoxChat.Text += "- " + "Nguyen Hau" + ": " + txtBoxMessage.Text + "\r\n";
            txtBoxMessage.Text = "";

            socket.Send(new SocketData((int)SocketCommand.SEND_MESSAGE, txtBoxChat.Text, new Point()));
            Listen();
        }

        private void txtBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true;
                txtBoxChat.Text += "- " + "Nguyen Hau" + ": " + txtBoxMessage.Text + "\r\n";
                txtBoxMessage.Text = "";

                socket.Send(new SocketData((int)SocketCommand.SEND_MESSAGE, txtBoxChat.Text, new Point()));
                Listen();
            }
        }
    }
}
