using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static GameCaro2.ChessBoardManager;

namespace GameCaro2
{
    public partial class FormComputer : Form
    {
        private ChessBoardManager ChessBoard;
        private int yPosition;
        private int xPosition;
        SqlCommand cmd;
        SqlDataAdapter adt;
        Db db;

        public FormComputer()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            InitializeComponent();
            InitializeScrollingText();
            InitializeHorizontalScrollingText();

            // Khởi tạo chessboard
            ChessBoard = new ChessBoardManager(pnlChessBoard, currentPlayerName, ptcBoxCurrentPlayer);
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            ChessBoard.EndedGame += ChessBoard_EndedGame;

            // Cài đặt thời gian cho game
            pcbCoolDown.Step = Constain.COOL_DOWN_STEP;
            pcbCoolDown.Maximum = Constain.COOL_DOWN_TIME;
            pcbCoolDown.Value = 0;
            tmCoolDown.Interval = Constain.COOL_DOWN_INTERVAL;

            NewGame();
            pnlChessBoard.Enabled = true;
        }

        private void InitializeHorizontalScrollingText()
        {
            label5.Text = "ᰔ♡♡♡♡ ◥Top❶sever◤ ---- Trò chơi Caro - 5 ô liên tiếp sẽ chiến thắng --- ꧁༒•TheKing•༒꧂ ♡♡♡♡";
            label5.AutoSize = true;

            // Bắt đầu từ ngoài bên trái của Panel
            xPosition = -label5.Width;

            timerScroll2.Interval = 40; // Tốc độ cuộn (ms)
            timerScroll2.Tick += timerScroll2_Tick; // Liên kết sự kiện Timer
            timerScroll2.Start();
        }

        private void timerScroll2_Tick(object sender, EventArgs e)
        {
            // Di chuyển label sang phải
            xPosition += 2; // Tăng giá trị để di chuyển sang phải
            label5.Location = new System.Drawing.Point(xPosition, label5.Location.Y);

            // Nếu label đã di chuyển hết khỏi Panel, đưa nó về lại bên trái
            if (xPosition > panel5.Width)
            {
                xPosition = -label5.Width;
            }
        }

        private void InitializeScrollingText()
        {
            label2.Text = "  Trò chơi Caro ᡣ𐭩 \n" +
                                 "      Winforms C# \n" +
                                 " ----- ♦ ♦ ♦ ----- \n" +
                                 "   ✧˖° Nhóm 5 ✧˖° \n" +
                                 "♡ Nguyyễn Phúc Hậu ♡ \n" +
                                 "♡ Vạn Tường Caesar ♡ \n" +
                                 "♡ Nguyễn Phi Phụng ♡ \n" +
                                 "♡ Nguyễn Nhật Băng ♡\n" +
                                 "♡ Đinh Văn Khoa ♡\n" +
                                 "♡ Ban Ngọc Tuấn ♡\n";


            label2.AutoSize = true;
            yPosition = panel2.Height; // Bắt đầu từ vị trí dưới cùng của Panel

            timerScroll.Interval = 40; // Tốc độ cuộn (ms)
            timerScroll.Tick += TimerScroll_Tick; // Liên kết sự kiện Timer
            timerScroll.Start();
        }

        private void TimerScroll_Tick(object sender, EventArgs e)
        {
            // Di chuyển label lên trên
            yPosition -= 2; // Tăng giá trị âm để di chuyển lên
            label2.Location = new System.Drawing.Point(label2.Location.X, yPosition);

            // Nếu label đã di chuyển hết khỏi Panel, đưa nó về lại bên dưới
            if (yPosition + label2.Height < 0)
            {
                yPosition = panel2.Height;
            }
        }

        void NewGame(bool isFromSocket = false)
        {
            // Cài lại thời gian game
            pcbCoolDown.Value = 0;
            tmCoolDown.Stop();

            ChessBoard.DrawChessBoard();

            // Nếu máy tính là 1 thì đánh trước
            if (ChessBoard.CurrentPlayer == 1)
            {
                ChessBoard.ComputerMove();
            }
        }

        void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
        }

        //void Undo()
        //{
        //    ChessBoard.Undo();
        //    pcbCoolDown.Value = 0;
        //}

        void Quit()
        {
            Application.Exit();
        }

        private void ChessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            tmCoolDown.Start();
            pnlChessBoard.Enabled = false;
            pcbCoolDown.Value = 0;

            // Lượt của máy
            ChessBoard.ComputerMove();
            pnlChessBoard.Enabled = true;
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();

            db = new Db();
            string winnerName = ChessBoard.Player[ChessBoard.CurrentPlayer].Name;
            string opponentName = ChessBoard.Player[ChessBoard.CurrentPlayer == 1 ? 0 : 1].Name == "Caesar" ? "Computer" : "";

            //MessageBox.Show(winnerName + opponentName);
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
                cmd.Parameters.AddWithValue("@GameMode", "1 vs Computer");

                cmd.ExecuteNonQuery(); // Thực thi truy vấn

                db.con.Close();

                // Thông báo người chiến thắng
                MessageBox.Show($"{winnerName} đã chiến thắng!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            pcbCoolDown.PerformStep();
            if (pcbCoolDown.Value >= pcbCoolDown.Maximum)
            {
                EndGame();
                MessageBox.Show("Hết thời gian!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void FormComputer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                //MessageBox.Show("Không thể thoát chương trình!");
            }
        }
    }
}