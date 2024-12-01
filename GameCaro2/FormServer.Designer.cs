namespace GameCaro2
{
    partial class FormServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServer));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.pnlPlayerInfo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbCoolDown2 = new System.Windows.Forms.ProgressBar();
            this.pcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.currentPlayerName = new System.Windows.Forms.Label();
            this.ptcBoxCurrentPlayer = new System.Windows.Forms.PictureBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.pnlFeature = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBoxMessage = new System.Windows.Forms.TextBox();
            this.txtBoxChat = new System.Windows.Forms.TextBox();
            this.btnServer = new System.Windows.Forms.Button();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.lblIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTextScroll = new System.Windows.Forms.Panel();
            this.lblScrollText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerScroll = new System.Windows.Forms.Timer(this.components);
            this.pnlPlayerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxCurrentPlayer)).BeginInit();
            this.pnlChat.SuspendLayout();
            this.pnlTextScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 50);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(820, 706);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // pnlPlayerInfo
            // 
            this.pnlPlayerInfo.BackColor = System.Drawing.Color.Black;
            this.pnlPlayerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerInfo.Controls.Add(this.label3);
            this.pnlPlayerInfo.Controls.Add(this.label2);
            this.pnlPlayerInfo.Controls.Add(this.pcbCoolDown2);
            this.pnlPlayerInfo.Controls.Add(this.pcbCoolDown);
            this.pnlPlayerInfo.Controls.Add(this.currentPlayerName);
            this.pnlPlayerInfo.Controls.Add(this.ptcBoxCurrentPlayer);
            this.pnlPlayerInfo.Location = new System.Drawing.Point(838, 331);
            this.pnlPlayerInfo.Name = "pnlPlayerInfo";
            this.pnlPlayerInfo.Size = new System.Drawing.Size(346, 146);
            this.pnlPlayerInfo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(143, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Trận đấu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nước đi";
            // 
            // pcbCoolDown2
            // 
            this.pcbCoolDown2.Location = new System.Drawing.Point(145, 84);
            this.pcbCoolDown2.Name = "pcbCoolDown2";
            this.pcbCoolDown2.Size = new System.Drawing.Size(196, 32);
            this.pcbCoolDown2.TabIndex = 7;
            // 
            // pcbCoolDown
            // 
            this.pcbCoolDown.Location = new System.Drawing.Point(145, 26);
            this.pcbCoolDown.Name = "pcbCoolDown";
            this.pcbCoolDown.Size = new System.Drawing.Size(196, 32);
            this.pcbCoolDown.TabIndex = 6;
            // 
            // currentPlayerName
            // 
            this.currentPlayerName.AutoSize = true;
            this.currentPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPlayerName.ForeColor = System.Drawing.Color.SpringGreen;
            this.currentPlayerName.Location = new System.Drawing.Point(18, 119);
            this.currentPlayerName.Name = "currentPlayerName";
            this.currentPlayerName.Size = new System.Drawing.Size(78, 18);
            this.currentPlayerName.TabIndex = 4;
            this.currentPlayerName.Text = "Unknown";
            // 
            // ptcBoxCurrentPlayer
            // 
            this.ptcBoxCurrentPlayer.BackColor = System.Drawing.Color.White;
            this.ptcBoxCurrentPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcBoxCurrentPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptcBoxCurrentPlayer.Location = new System.Drawing.Point(3, 3);
            this.ptcBoxCurrentPlayer.Name = "ptcBoxCurrentPlayer";
            this.ptcBoxCurrentPlayer.Size = new System.Drawing.Size(136, 113);
            this.ptcBoxCurrentPlayer.TabIndex = 0;
            this.ptcBoxCurrentPlayer.TabStop = false;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.BackColor = System.Drawing.Color.LightCoral;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.ForeColor = System.Drawing.Color.White;
            this.lblServer.Location = new System.Drawing.Point(12, 6);
            this.lblServer.Name = "lblServer";
            this.lblServer.Padding = new System.Windows.Forms.Padding(90, 8, 70, 8);
            this.lblServer.Size = new System.Drawing.Size(339, 38);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Đang chờ kết nối...";
            // 
            // pnlFeature
            // 
            this.pnlFeature.BackColor = System.Drawing.Color.White;
            this.pnlFeature.BackgroundImage = global::GameCaro2.Properties.Resources.uth;
            this.pnlFeature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFeature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFeature.Location = new System.Drawing.Point(838, 50);
            this.pnlFeature.Name = "pnlFeature";
            this.pnlFeature.Size = new System.Drawing.Size(346, 91);
            this.pnlFeature.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1069, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát phòng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(954, 9);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(109, 35);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.Text = "Đánh lại";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNewGame.Location = new System.Drawing.Point(838, 9);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(110, 35);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "Ván mới";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.Color.Black;
            this.pnlChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChat.Controls.Add(this.btnSend);
            this.pnlChat.Controls.Add(this.txtBoxMessage);
            this.pnlChat.Controls.Add(this.txtBoxChat);
            this.pnlChat.Location = new System.Drawing.Point(838, 483);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(346, 273);
            this.pnlChat.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(220, 241);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 27);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMessage.Location = new System.Drawing.Point(3, 241);
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(211, 27);
            this.txtBoxMessage.TabIndex = 1;
            this.txtBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxMessage_KeyDown);
            // 
            // txtBoxChat
            // 
            this.txtBoxChat.BackColor = System.Drawing.Color.White;
            this.txtBoxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxChat.Location = new System.Drawing.Point(3, 3);
            this.txtBoxChat.Multiline = true;
            this.txtBoxChat.Name = "txtBoxChat";
            this.txtBoxChat.Size = new System.Drawing.Size(338, 232);
            this.txtBoxChat.TabIndex = 0;
            // 
            // btnServer
            // 
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.Location = new System.Drawing.Point(380, 7);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(179, 38);
            this.btnServer.TabIndex = 5;
            this.btnServer.Text = "Tạo phòng";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblIP.Location = new System.Drawing.Point(684, 16);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(84, 20);
            this.lblIP.TabIndex = 9;
            this.lblIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(566, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP Server:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GameCaro2.Properties.Resources.caro;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.CausesValidation = false;
            this.panel1.Location = new System.Drawing.Point(838, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 178);
            this.panel1.TabIndex = 11;
            // 
            // pnlTextScroll
            // 
            this.pnlTextScroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTextScroll.Controls.Add(this.lblScrollText);
            this.pnlTextScroll.Location = new System.Drawing.Point(1011, 170);
            this.pnlTextScroll.Name = "pnlTextScroll";
            this.pnlTextScroll.Size = new System.Drawing.Size(173, 155);
            this.pnlTextScroll.TabIndex = 12;
            // 
            // lblScrollText
            // 
            this.lblScrollText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScrollText.AutoSize = true;
            this.lblScrollText.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrollText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblScrollText.Location = new System.Drawing.Point(3, 0);
            this.lblScrollText.Name = "lblScrollText";
            this.lblScrollText.Size = new System.Drawing.Size(51, 20);
            this.lblScrollText.TabIndex = 0;
            this.lblScrollText.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Location = new System.Drawing.Point(1011, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới thiệu";
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1196, 770);
            this.Controls.Add(this.pnlPlayerInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlTextScroll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.pnlFeature);
            this.Controls.Add(this.pnlChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormServer";
            this.Text = "Form Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServer_FormClosing_1);
            this.Shown += new System.EventHandler(this.FormServer_Shown);
            this.pnlPlayerInfo.ResumeLayout(false);
            this.pnlPlayerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxCurrentPlayer)).EndInit();
            this.pnlChat.ResumeLayout(false);
            this.pnlChat.PerformLayout();
            this.pnlTextScroll.ResumeLayout(false);
            this.pnlTextScroll.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel pnlFeature;
        private System.Windows.Forms.Panel pnlPlayerInfo;
        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.PictureBox ptcBoxCurrentPlayer;
        private System.Windows.Forms.Label currentPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pcbCoolDown2;
        private System.Windows.Forms.ProgressBar pcbCoolDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxChat;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtBoxMessage;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTextScroll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScrollText;
        private System.Windows.Forms.Timer timerScroll;
    }
}

