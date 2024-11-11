using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public class ChessBoardManager
    {
        // Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }
        private List<Player> player;
        public List<Player> Player 
        {
            get { return player;  }
            set { player = value; } 
        }

        private int currentPlayer;
        public int CurrentPlayer 
        { 
            get { return currentPlayer;}
            set { currentPlayer = value; }
        }

        // Initialize
        public ChessBoardManager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
            this.Player = new List<Player>()
            {
                new Player("NguyenHau", Image.FromFile(Application.StartupPath + "\\Resources\\x_mark.png")),
                new Player("HieuNhi", Image.FromFile(Application.StartupPath + "\\Resources\\o_mark.png"))
            };

            CurrentPlayer = 0;
        }

        // Methods
        public void DrawChessBoard()
        {
            Button oldBtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Constain.CHESS_BOARD_WIDTH; i++)
            {
                for (int j = 0; j < Constain.CHESS_BOARD_HEIGH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Constain.CHESS_WIDTH,
                        Height = Constain.CHESS_HEIGH,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                    };

                    btn.Click += Btn_Click;

                    chessBoard.Controls.Add(btn);
                    oldBtn = btn;
                }
                oldBtn.Location = new Point(0, oldBtn.Location.Y + Constain.CHESS_HEIGH);
                oldBtn.Width = 0;
                oldBtn.Height = 0;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null)
                return;

            btn.BackgroundImage = Player[CurrentPlayer].Mark;
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }
    }
}
