using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        ChessBoardManager ChessBoard;
        public Form1()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(pnlChessBoard, txtLabelName, ptcMark);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            pcbCoolDown.Step = Constain.COOL_DOWN_STEP;
            pcbCoolDown.Maximum = Constain.COOL_DOWN_TIME;
            pcbCoolDown.Value = 0;
            
            tmCoolDown.Interval = Constain.COOL_DOWN_INTERVAL;

            ChessBoard.DrawChessBoard();
        }

        void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            MessageBox.Show("Ket thuc");
        }

        private void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            tmCoolDown.Start();
            pcbCoolDown.Value = 0;
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            pcbCoolDown.PerformStep();

            if (pcbCoolDown.Value >= pcbCoolDown.Maximum)
            {
                EndGame();
            }
        }
    }
}
