using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        ChessBoardManager ChessBoard;
        HubConnection hubConnection;
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

            hubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7157/ChatHub")
                .Build();
            hubConnection.Closed += HubConnection_Closed;
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
        private async void Form1_Load_1(object sender, EventArgs e)
        {
            hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                var newMessage = $"{user}: {message} ";
                lstMessage.Items.Add(newMessage);
            });
            try
            {
                await hubConnection.StartAsync();
                lstMessage.Items.Add("Connection started");
            }
            catch (Exception ex)
            {
                lstMessage.Items.Add(ex.Message);
            }
        }
        private async Task HubConnection_Closed(Exception arg)
        {
            if (arg == null)
            {
                arg = new Exception("No specific error provided");
            }

            lstMessage.Items.Add($"Connection closed due to error: {arg.Message}");

            await Task.Delay(new Random().Next(0, 5) * 1000);
            await hubConnection.StartAsync();
        }
        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                await hubConnection.InvokeAsync("SendMessage", txtUser.Text, txtMessage.Text);
            }
            catch (Exception ex)
            {
                lstMessage.Items.Add(ex.Message);
            }
        }

    }
}
    

