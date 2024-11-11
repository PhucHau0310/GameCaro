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
            this.chatBox = new System.Windows.Forms.TextBox();
            this.messBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
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
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(858, 676);
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
            this.pnlChat.Controls.Add(this.button1);
            this.pnlChat.Controls.Add(this.messBox);
            this.pnlChat.Controls.Add(this.chatBox);
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
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(3, 3);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(380, 154);
            this.chatBox.TabIndex = 0;
            // 
            // messBox
            // 
            this.messBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messBox.Location = new System.Drawing.Point(3, 166);
            this.messBox.Name = "messBox";
            this.messBox.Size = new System.Drawing.Size(249, 30);
            this.messBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(258, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox messBox;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.Timer tmCoolDown;
    }
}

