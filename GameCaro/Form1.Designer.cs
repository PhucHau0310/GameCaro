namespace GameCaro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.pnlImageCaro = new System.Windows.Forms.Panel();
            this.pteBoxCaro = new System.Windows.Forms.PictureBox();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLan = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.ptcMark = new System.Windows.Forms.PictureBox();
            this.pcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txtLabelName = new System.Windows.Forms.TextBox();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lstMessage = new System.Windows.Forms.ListBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnlImageCaro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pteBoxCaro)).BeginInit();
            this.pnlChat.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcMark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 66);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(858, 622);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // pnlImageCaro
            // 
            this.pnlImageCaro.Controls.Add(this.pteBoxCaro);
            this.pnlImageCaro.Location = new System.Drawing.Point(879, 12);
            this.pnlImageCaro.Name = "pnlImageCaro";
            this.pnlImageCaro.Size = new System.Drawing.Size(386, 214);
            this.pnlImageCaro.TabIndex = 1;
            // 
            // pteBoxCaro
            // 
            this.pteBoxCaro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pteBoxCaro.BackColor = System.Drawing.SystemColors.Control;
            this.pteBoxCaro.BackgroundImage = global::GameCaro.Properties.Resources.caro;
            this.pteBoxCaro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pteBoxCaro.Location = new System.Drawing.Point(3, 3);
            this.pteBoxCaro.Name = "pteBoxCaro";
            this.pteBoxCaro.Size = new System.Drawing.Size(383, 208);
            this.pteBoxCaro.TabIndex = 0;
            this.pteBoxCaro.TabStop = false;
            // 
            // pnlChat
            // 
            this.pnlChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChat.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChat.Controls.Add(this.btnSend);
            this.pnlChat.Controls.Add(this.txtMessage);
            this.pnlChat.Controls.Add(this.txtUser);
            this.pnlChat.Controls.Add(this.lstMessage);
            this.pnlChat.Controls.Add(this.lblMessage);
            this.pnlChat.Controls.Add(this.lblUser);
            this.pnlChat.Location = new System.Drawing.Point(879, 232);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(386, 205);
            this.pnlChat.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnLan);
            this.panel4.Controls.Add(this.txtIP);
            this.panel4.Controls.Add(this.ptcMark);
            this.panel4.Controls.Add(this.pcbCoolDown);
            this.panel4.Controls.Add(this.txtLabelName);
            this.panel4.Location = new System.Drawing.Point(876, 443);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 245);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = " 5 in a line for win";
            // 
            // btnLan
            // 
            this.btnLan.Location = new System.Drawing.Point(3, 146);
            this.btnLan.Name = "btnLan";
            this.btnLan.Size = new System.Drawing.Size(192, 40);
            this.btnLan.TabIndex = 4;
            this.btnLan.Text = "Connect";
            this.btnLan.UseVisualStyleBackColor = true;
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(6, 110);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(189, 30);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "127.0.0.1";
            // 
            // ptcMark
            // 
            this.ptcMark.BackColor = System.Drawing.SystemColors.Control;
            this.ptcMark.Location = new System.Drawing.Point(201, 18);
            this.ptcMark.Name = "ptcMark";
            this.ptcMark.Size = new System.Drawing.Size(172, 167);
            this.ptcMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcMark.TabIndex = 2;
            this.ptcMark.TabStop = false;
            // 
            // pcbCoolDown
            // 
            this.pcbCoolDown.Location = new System.Drawing.Point(6, 61);
            this.pcbCoolDown.Name = "pcbCoolDown";
            this.pcbCoolDown.Size = new System.Drawing.Size(189, 37);
            this.pcbCoolDown.TabIndex = 1;
            // 
            // txtLabelName
            // 
            this.txtLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelName.Location = new System.Drawing.Point(6, 18);
            this.txtLabelName.Name = "txtLabelName";
            this.txtLabelName.ReadOnly = true;
            this.txtLabelName.Size = new System.Drawing.Size(189, 30);
            this.txtLabelName.TabIndex = 0;
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 156);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 16);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User :";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 180);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(70, 16);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message :";
            // 
            // lstMessage
            // 
            this.lstMessage.FormattingEnabled = true;
            this.lstMessage.ItemHeight = 16;
            this.lstMessage.Location = new System.Drawing.Point(15, 2);
            this.lstMessage.Name = "lstMessage";
            this.lstMessage.Size = new System.Drawing.Size(355, 132);
            this.lstMessage.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(92, 150);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(210, 22);
            this.txtUser.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(92, 178);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(210, 22);
            this.txtMessage.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(308, 177);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 700);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.pnlImageCaro);
            this.Controls.Add(this.pnlChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.pnlImageCaro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pteBoxCaro)).EndInit();
            this.pnlChat.ResumeLayout(false);
            this.pnlChat.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel pnlImageCaro;
        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pteBoxCaro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLan;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.PictureBox ptcMark;
        private System.Windows.Forms.ProgressBar pcbCoolDown;
        private System.Windows.Forms.TextBox txtLabelName;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ListBox lstMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblUser;
    }
}

