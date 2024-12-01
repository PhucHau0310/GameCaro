namespace GameCaro2
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.pnlFeature = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.pnlPlayerInfo = new System.Windows.Forms.Panel();
            this.ptcBoxCurrentPlayer = new System.Windows.Forms.PictureBox();
            this.currentPlayerName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.pcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBoxMessage = new System.Windows.Forms.TextBox();
            this.txtBoxChat = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtBoxClient = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTextScrollHorizontal = new System.Windows.Forms.Panel();
            this.lblScrollTextHorizontal = new System.Windows.Forms.Label();
            this.timerScrollHorizontal = new System.Windows.Forms.Timer(this.components);
            this.pnlFeature.SuspendLayout();
            this.pnlPlayerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxCurrentPlayer)).BeginInit();
            this.pnlChat.SuspendLayout();
            this.pnlTextScrollHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 52);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(820, 706);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // pnlFeature
            // 
            this.pnlFeature.BackColor = System.Drawing.Color.Pink;
            this.pnlFeature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFeature.Controls.Add(this.btnQuit);
            this.pnlFeature.Controls.Add(this.btnNew);
            this.pnlFeature.Controls.Add(this.btnUndo);
            this.pnlFeature.Location = new System.Drawing.Point(850, 14);
            this.pnlFeature.Name = "pnlFeature";
            this.pnlFeature.Size = new System.Drawing.Size(338, 38);
            this.pnlFeature.TabIndex = 1;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(233, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(97, 31);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Thoát phòng";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(12, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(97, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Ván mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(115, 2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(112, 31);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.Text = "Đánh lại";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // pnlPlayerInfo
            // 
            this.pnlPlayerInfo.BackColor = System.Drawing.Color.White;
            this.pnlPlayerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerInfo.Controls.Add(this.ptcBoxCurrentPlayer);
            this.pnlPlayerInfo.Controls.Add(this.currentPlayerName);
            this.pnlPlayerInfo.Controls.Add(this.panel2);
            this.pnlPlayerInfo.Controls.Add(this.label5);
            this.pnlPlayerInfo.Controls.Add(this.label4);
            this.pnlPlayerInfo.Controls.Add(this.progressBar2);
            this.pnlPlayerInfo.Controls.Add(this.pcbCoolDown);
            this.pnlPlayerInfo.Location = new System.Drawing.Point(850, 201);
            this.pnlPlayerInfo.Name = "pnlPlayerInfo";
            this.pnlPlayerInfo.Size = new System.Drawing.Size(338, 244);
            this.pnlPlayerInfo.TabIndex = 2;
            // 
            // ptcBoxCurrentPlayer
            // 
            this.ptcBoxCurrentPlayer.BackgroundImage = global::GameCaro2.Properties.Resources.o_mark;
            this.ptcBoxCurrentPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcBoxCurrentPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptcBoxCurrentPlayer.Location = new System.Drawing.Point(12, 21);
            this.ptcBoxCurrentPlayer.Name = "ptcBoxCurrentPlayer";
            this.ptcBoxCurrentPlayer.Size = new System.Drawing.Size(136, 113);
            this.ptcBoxCurrentPlayer.TabIndex = 11;
            this.ptcBoxCurrentPlayer.TabStop = false;
            // 
            // currentPlayerName
            // 
            this.currentPlayerName.AutoSize = true;
            this.currentPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPlayerName.ForeColor = System.Drawing.Color.Red;
            this.currentPlayerName.Location = new System.Drawing.Point(38, 137);
            this.currentPlayerName.Name = "currentPlayerName";
            this.currentPlayerName.Size = new System.Drawing.Size(78, 18);
            this.currentPlayerName.TabIndex = 8;
            this.currentPlayerName.Text = "Unknown";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::GameCaro2.Properties.Resources.fight;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(182, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 113);
            this.panel2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Trận đấu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nước đi";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(109, 203);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(223, 32);
            this.progressBar2.TabIndex = 5;
            // 
            // pcbCoolDown
            // 
            this.pcbCoolDown.Location = new System.Drawing.Point(109, 165);
            this.pcbCoolDown.Name = "pcbCoolDown";
            this.pcbCoolDown.Size = new System.Drawing.Size(223, 32);
            this.pcbCoolDown.TabIndex = 4;
            // 
            // pnlChat
            // 
            this.pnlChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChat.Controls.Add(this.btnSend);
            this.pnlChat.Controls.Add(this.txtBoxMessage);
            this.pnlChat.Controls.Add(this.txtBoxChat);
            this.pnlChat.Location = new System.Drawing.Point(850, 451);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(338, 307);
            this.pnlChat.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Teal;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(198, 269);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(135, 33);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMessage.Location = new System.Drawing.Point(3, 272);
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(190, 30);
            this.txtBoxMessage.TabIndex = 1;
            this.txtBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxMessage_KeyDown);
            // 
            // txtBoxChat
            // 
            this.txtBoxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxChat.Location = new System.Drawing.Point(-1, 3);
            this.txtBoxChat.Multiline = true;
            this.txtBoxChat.Name = "txtBoxChat";
            this.txtBoxChat.Size = new System.Drawing.Size(338, 260);
            this.txtBoxChat.TabIndex = 0;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.BackColor = System.Drawing.Color.LightCoral;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(12, 9);
            this.lblClient.Name = "lblClient";
            this.lblClient.Padding = new System.Windows.Forms.Padding(70, 8, 70, 8);
            this.lblClient.Size = new System.Drawing.Size(373, 36);
            this.lblClient.TabIndex = 4;
            this.lblClient.Text = "Chưa kết nối tới phòng nào";
            // 
            // txtBoxClient
            // 
            this.txtBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxClient.Location = new System.Drawing.Point(467, 13);
            this.txtBoxClient.Name = "txtBoxClient";
            this.txtBoxClient.Size = new System.Drawing.Size(158, 30);
            this.txtBoxClient.TabIndex = 5;
            this.txtBoxClient.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(642, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(124, 32);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GameCaro2.Properties.Resources.uth;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(850, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 89);
            this.panel1.TabIndex = 9;
            // 
            // pnlTextScrollHorizontal
            // 
            this.pnlTextScrollHorizontal.BackColor = System.Drawing.Color.Teal;
            this.pnlTextScrollHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTextScrollHorizontal.Controls.Add(this.lblScrollTextHorizontal);
            this.pnlTextScrollHorizontal.Location = new System.Drawing.Point(850, 153);
            this.pnlTextScrollHorizontal.Name = "pnlTextScrollHorizontal";
            this.pnlTextScrollHorizontal.Size = new System.Drawing.Size(338, 42);
            this.pnlTextScrollHorizontal.TabIndex = 11;
            // 
            // lblScrollTextHorizontal
            // 
            this.lblScrollTextHorizontal.AutoSize = true;
            this.lblScrollTextHorizontal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrollTextHorizontal.ForeColor = System.Drawing.Color.White;
            this.lblScrollTextHorizontal.Location = new System.Drawing.Point(9, 10);
            this.lblScrollTextHorizontal.Name = "lblScrollTextHorizontal";
            this.lblScrollTextHorizontal.Size = new System.Drawing.Size(52, 18);
            this.lblScrollTextHorizontal.TabIndex = 0;
            this.lblScrollTextHorizontal.Text = "label1";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1196, 770);
            this.Controls.Add(this.pnlPlayerInfo);
            this.Controls.Add(this.pnlTextScrollHorizontal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtBoxClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.pnlFeature);
            this.Controls.Add(this.pnlChessBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClient";
            this.Text = "Form Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClient_FormClosing);
            this.pnlFeature.ResumeLayout(false);
            this.pnlPlayerInfo.ResumeLayout(false);
            this.pnlPlayerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxCurrentPlayer)).EndInit();
            this.pnlChat.ResumeLayout(false);
            this.pnlChat.PerformLayout();
            this.pnlTextScrollHorizontal.ResumeLayout(false);
            this.pnlTextScrollHorizontal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel pnlFeature;
        private System.Windows.Forms.Panel pnlPlayerInfo;
        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtBoxClient;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtBoxChat;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtBoxMessage;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.ProgressBar pcbCoolDown;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentPlayerName;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlTextScrollHorizontal;
        private System.Windows.Forms.Label lblScrollTextHorizontal;
        private System.Windows.Forms.Timer timerScrollHorizontal;
        private System.Windows.Forms.PictureBox ptcBoxCurrentPlayer;
    }
}