using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro2
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
            get { return player; }
            set { player = value; }
        }

        private int currentPlayer = 0; // 0 for Nguyen Hau, 1 for Caesar;
        public int CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }

        private Label playerName;
        public Label PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        private PictureBox playerMark;
        public PictureBox PlayerMark
        {
            get { return playerMark; }
            set { playerMark = value; }
        }

        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private event EventHandler<ButtonClickEvent> playerMarked;
        public event EventHandler<ButtonClickEvent> PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }

        private Stack<PlayInfo> playTimeLine;
        public Stack<PlayInfo> PlayTimeLine
        {
            get { return playTimeLine; }
            set { playTimeLine = value; }
        }

        //

        private void ChessBoardManager_playerMarked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // Initialize
        public ChessBoardManager(Panel chessBoard, Label playerName, PictureBox playerMark)
        {
            this.ChessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = playerMark;

            string resourcePath = Application.StartupPath + "\\Resources\\";
            this.Player = new List<Player>()
            {
                //new Player("Nguyen Hau", Image.FromFile(resourcePath + "x_mark.png")),
                //new Player("CaeSar", Image.FromFile(resourcePath + "o_mark.png"))
                new Player("Nguyen Hau", Properties.Resources.x_mark),
                new Player("Caesar", Properties.Resources.o_mark)
            };
        }

        // Methods
        public void DrawChessBoard()
        {
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();

            PlayTimeLine = new Stack<PlayInfo>();

            CurrentPlayer = 0;
            ChangePlayer();

            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Constain.CHESS_BOARD_HEIGH; i++)
            {
                Matrix.Add(new List<Button>());

                for (int j = 0; j < Constain.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Constain.CHESS_WIDTH,
                        Height = Constain.CHESS_HEIGH,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString() // xac dinh duoc button o cot i (theo tag) va hang j (theo for)
                    };

                    btn.Click += Btn_Click;

                    chessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn);

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

            Mark(btn);

            PlayTimeLine.Push(new PlayInfo(GetChessPoint(btn), CurrentPlayer));

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            ChangePlayer();

            if (playerMarked != null)
            {
                playerMarked(this, new ButtonClickEvent(GetChessPoint(btn)));
            }

            if (isEndGame(btn))
            {
                EndGame();
            }
        }
        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
        }
        private void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }

        public void OtherPlayerMark(Point point)
        {
            Button btn = Matrix[point.Y][point.X];

            if (btn.BackgroundImage != null)
                return;

            ChessBoard.Enabled = true;

            Mark(btn);

            PlayTimeLine.Push(new PlayInfo(GetChessPoint(btn), CurrentPlayer));

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            ChangePlayer();

            if (isEndGame(btn))
            {
                EndGame();
            }
        }
        
        // Choi voi may
        public void ComputerMove()
        {
            if (CurrentPlayer != 1) return;

            Point bestMove = FindBestMove();

            if (bestMove != Point.Empty)
            {
                Button btn = Matrix[bestMove.Y][bestMove.X];
                Mark(btn);
                PlayTimeLine.Push(new PlayInfo(GetChessPoint(btn), CurrentPlayer));

                CurrentPlayer = 0;
                ChangePlayer();

                if (isEndGame(btn))
                {
                    EndGame();
                }
            }
        }

        private Point FindBestMove()
        {
            // Check for immediate winning move
            Point winningMove = FindWinningMove(1);
            if (winningMove != Point.Empty) return winningMove;

            // Block player's winning move
            Point blockingMove = FindWinningMove(0);
            if (blockingMove != Point.Empty) return blockingMove;

            // Create strategic opportunities
            Point strategicMove = FindStrategicMove();
            if (strategicMove != Point.Empty) return strategicMove;

            // Fallback to random move
            return GetRandomAvailablePoint();
        }

        private Point FindWinningMove(int player)
        {
            for (int y = 0; y < Constain.CHESS_BOARD_HEIGH; y++)
            {
                for (int x = 0; x < Constain.CHESS_BOARD_WIDTH; x++)
                {
                    if (Matrix[y][x].BackgroundImage == null)
                    {
                        // Simulate move
                        Matrix[y][x].BackgroundImage = Player[player].Mark;

                        bool isWinningMove = isEndGame(Matrix[y][x]);

                        // Undo simulation
                        Matrix[y][x].BackgroundImage = null;

                        if (isWinningMove)
                        {
                            return new Point(x, y);
                        }
                    }
                }
            }
            return Point.Empty;
        }

        private Point FindStrategicMove()
        {
            // Prioritize center and near existing marks
            List<Point> strategicPoints = new List<Point>();

            // Center of board
            Point center = new Point(
                Constain.CHESS_BOARD_WIDTH / 2,
                Constain.CHESS_BOARD_HEIGH / 2
            );

            if (Matrix[center.Y][center.X].BackgroundImage == null)
                return center;

            // Look for points near existing marks
            for (int y = 0; y < Constain.CHESS_BOARD_HEIGH; y++)
            {
                for (int x = 0; x < Constain.CHESS_BOARD_WIDTH; x++)
                {
                    if (Matrix[y][x].BackgroundImage == null &&
                        HasNearbyMark(x, y))
                    {
                        strategicPoints.Add(new Point(x, y));
                    }
                }
            }

            return strategicPoints.Count > 0
                ? strategicPoints[new Random().Next(strategicPoints.Count)]
                : Point.Empty;
        }

        private bool HasNearbyMark(int x, int y)
        {
            int[] dx = { -1, 0, 1, -1, 1, -1, 0, 1 };
            int[] dy = { -1, -1, -1, 0, 0, 1, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                int newX = x + dx[i];
                int newY = y + dy[i];

                if (newX >= 0 && newX < Constain.CHESS_BOARD_WIDTH &&
                    newY >= 0 && newY < Constain.CHESS_BOARD_HEIGH)
                {
                    if (Matrix[newY][newX].BackgroundImage != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private Point GetRandomAvailablePoint()
        {
            List<Point> availablePoints = new List<Point>();
            for (int y = 0; y < Constain.CHESS_BOARD_HEIGH; y++)
            {
                for (int x = 0; x < Constain.CHESS_BOARD_WIDTH; x++)
                {
                    if (Matrix[y][x].BackgroundImage == null)
                    {
                        availablePoints.Add(new Point(x, y));
                    }
                }
            }
            return availablePoints.Count > 0
                ? availablePoints[new Random().Next(availablePoints.Count)]
                : Point.Empty;
        }
      
        //
        private void EndGame()
        {
            if (endedGame != null)
            {
                endedGame(this, new EventArgs());
            }
        }
        public bool Undo()
        {
            if (PlayTimeLine.Count <= 0) return false;

            PlayInfo oldPoint = PlayTimeLine.Peek();

            bool isUndo1 = UndoAStep();
            bool isUndo2 = UndoAStep();

            CurrentPlayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;

            return isUndo1 && isUndo2;
        }
        private bool UndoAStep()
        {
            if (PlayTimeLine.Count <= 0) return false;

            PlayInfo oldPoint = PlayTimeLine.Pop();
            Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];
            btn.BackgroundImage = null;

            if (PlayTimeLine.Count <= 0)
            {
                CurrentPlayer = 0;
            }
            else
            {
                oldPoint = PlayTimeLine.Peek();

            }

            ChangePlayer();
            return true;
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }
        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);

            return point;
        }
        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                {
                    break;
                }
            }

            int countRight = 0;
            for (int i = point.X + 1; i < Constain.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                {
                    break;
                }
            }
            return countLeft + countRight == 5;
        }
        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < Constain.CHESS_BOARD_HEIGH; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }
            return countTop + countBottom == 5;
        }
        private bool isEndPrimary(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                {
                    break;
                }

                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }

            int countBottom = 0;
            for (int i = 1; i <= Constain.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Constain.CHESS_BOARD_HEIGH || point.X + i >= Constain.CHESS_BOARD_WIDTH)
                {
                    break;
                }
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }
            return countTop + countBottom == 5;
        }
        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Constain.CHESS_BOARD_WIDTH || point.Y - i < 0)
                {
                    break;
                }

                //if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                //{
                //    countTop++;
                //}
                //else
                //{
                //    break;
                //}

                if (point.X + i < Constain.CHESS_BOARD_WIDTH && point.Y - i >= 0 &&
                    Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }

            int countBottom = 0;
            for (int i = 1; i <= Constain.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Constain.CHESS_BOARD_HEIGH || point.X - i < 0)
                {
                    break;
                }
                //if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                //{
                //    countBottom++;
                //}
                //else
                //{
                //    break;
                //}
                if (point.Y + i < Constain.CHESS_BOARD_HEIGH && point.X - i >= 0 &&
                     Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }
            return countTop + countBottom == 5;
        }

        public class ButtonClickEvent : EventArgs
        {
            private Point clickedPoint;

            public Point ClickedPoint
            {
                get { return clickedPoint; }
                set { clickedPoint = value; }
            }

            public ButtonClickEvent(Point point)
            {
                this.ClickedPoint = point;
            }
        }
    }
}
