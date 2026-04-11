namespace com.codeBlack.winLock
{
    partial class WinLock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinLock));
            WinLockLabel = new Label();
            panel1 = new Panel();
            logo = new PictureBox();
            username = new Label();
            userRole = new Label();
            pictureBox1 = new PictureBox();
            sidebar = new FlowLayoutPanel();
            serviceMgr_btn = new Button();
            decryptButton = new Button();
            button1 = new Button();
            accountsMgr_btn = new Button();
            signOut_btn = new Button();
            panel5 = new Panel();
            label3 = new Label();
            label2 = new Label();
            systemTimeText = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            systime = new Label();
            label1 = new Label();
            expirationDate = new Label();
            panel2 = new Panel();
            activityLogHeader = new Label();
            authLogsContainer = new RichTextBox();
            panel3 = new Panel();
            encryptActivityheader = new Label();
            encryptionLogsContainer = new RichTextBox();
            panel4 = new Panel();
            processActivityHeader = new Label();
            processLogsContainer = new RichTextBox();
            updateProcess = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidebar.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // WinLockLabel
            // 
            WinLockLabel.AutoSize = true;
            WinLockLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WinLockLabel.ForeColor = Color.White;
            WinLockLabel.Location = new Point(79, 11);
            WinLockLabel.Margin = new Padding(4, 0, 4, 0);
            WinLockLabel.Name = "WinLockLabel";
            WinLockLabel.Size = new Size(207, 60);
            WinLockLabel.TabIndex = 6;
            WinLockLabel.Text = "WinLOCK";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 77, 146);
            panel1.Controls.Add(logo);
            panel1.Controls.Add(username);
            panel1.Controls.Add(userRole);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(WinLockLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 80);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // logo
            // 
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Location = new Point(12, 11);
            logo.Name = "logo";
            logo.Size = new Size(60, 60);
            logo.TabIndex = 12;
            logo.TabStop = false;
            // 
            // username
            // 
            username.FlatStyle = FlatStyle.Flat;
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.White;
            username.Location = new Point(749, 16);
            username.Margin = new Padding(4, 0, 4, 0);
            username.Name = "username";
            username.RightToLeft = RightToLeft.Yes;
            username.Size = new Size(281, 28);
            username.TabIndex = 10;
            username.Text = "user";
            username.TextAlign = ContentAlignment.MiddleLeft;
            username.Click += username_Click;
            // 
            // userRole
            // 
            userRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userRole.ForeColor = Color.White;
            userRole.Location = new Point(749, 45);
            userRole.Margin = new Padding(4, 0, 4, 0);
            userRole.Name = "userRole";
            userRole.RightToLeft = RightToLeft.Yes;
            userRole.Size = new Size(281, 28);
            userRole.TabIndex = 11;
            userRole.Text = "role";
            userRole.TextAlign = ContentAlignment.MiddleLeft;
            userRole.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1038, 11);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(18, 18, 18);
            sidebar.Controls.Add(decryptButton);
            sidebar.Controls.Add(button1);
            sidebar.Controls.Add(serviceMgr_btn);
            sidebar.Controls.Add(accountsMgr_btn);
            sidebar.Controls.Add(signOut_btn);
            sidebar.Controls.Add(panel5);
            sidebar.Location = new Point(0, 80);
            sidebar.Margin = new Padding(0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 690);
            sidebar.TabIndex = 8;
            // 
            // serviceMgr_btn
            // 
            serviceMgr_btn.BackColor = Color.FromArgb(18, 18, 18);
            serviceMgr_btn.BackgroundImageLayout = ImageLayout.Center;
            serviceMgr_btn.Cursor = Cursors.Hand;
            serviceMgr_btn.FlatAppearance.BorderSize = 0;
            serviceMgr_btn.FlatStyle = FlatStyle.Flat;
            serviceMgr_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceMgr_btn.ForeColor = Color.White;
            serviceMgr_btn.Image = (Image)resources.GetObject("serviceMgr_btn.Image");
            serviceMgr_btn.ImageAlign = ContentAlignment.MiddleLeft;
            serviceMgr_btn.Location = new Point(0, 144);
            serviceMgr_btn.Margin = new Padding(0);
            serviceMgr_btn.Name = "serviceMgr_btn";
            serviceMgr_btn.Padding = new Padding(28, 0, 0, 0);
            serviceMgr_btn.Size = new Size(200, 72);
            serviceMgr_btn.TabIndex = 11;
            serviceMgr_btn.Text = "Services Manager";
            serviceMgr_btn.UseMnemonic = false;
            serviceMgr_btn.UseVisualStyleBackColor = false;
            // 
            // decryptButton
            // 
            decryptButton.AutoSize = true;
            decryptButton.BackColor = Color.FromArgb(18, 18, 18);
            decryptButton.BackgroundImageLayout = ImageLayout.Center;
            decryptButton.Cursor = Cursors.Hand;
            decryptButton.FlatAppearance.BorderSize = 0;
            decryptButton.FlatStyle = FlatStyle.Flat;
            decryptButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            decryptButton.ForeColor = Color.White;
            decryptButton.Image = (Image)resources.GetObject("decryptButton.Image");
            decryptButton.ImageAlign = ContentAlignment.MiddleLeft;
            decryptButton.Location = new Point(0, 0);
            decryptButton.Margin = new Padding(0);
            decryptButton.Name = "decryptButton";
            decryptButton.Padding = new Padding(28, 0, 0, 0);
            decryptButton.Size = new Size(200, 72);
            decryptButton.TabIndex = 9;
            decryptButton.TabStop = false;
            decryptButton.Text = "DecryptFile";
            decryptButton.UseMnemonic = false;
            decryptButton.UseVisualStyleBackColor = false;
            decryptButton.Click += decryptButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(18, 18, 18);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 72);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(28, 0, 0, 0);
            button1.Size = new Size(200, 72);
            button1.TabIndex = 10;
            button1.Text = "EncryptFile";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += encryptButton_Click;
            // 
            // accountsMgr_btn
            // 
            accountsMgr_btn.BackColor = Color.FromArgb(18, 18, 18);
            accountsMgr_btn.BackgroundImageLayout = ImageLayout.Center;
            accountsMgr_btn.Cursor = Cursors.Hand;
            accountsMgr_btn.FlatAppearance.BorderSize = 0;
            accountsMgr_btn.FlatStyle = FlatStyle.Flat;
            accountsMgr_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountsMgr_btn.ForeColor = Color.White;
            accountsMgr_btn.Image = (Image)resources.GetObject("accountsMgr_btn.Image");
            accountsMgr_btn.ImageAlign = ContentAlignment.MiddleLeft;
            accountsMgr_btn.Location = new Point(0, 216);
            accountsMgr_btn.Margin = new Padding(0);
            accountsMgr_btn.Name = "accountsMgr_btn";
            accountsMgr_btn.Padding = new Padding(28, 0, 0, 0);
            accountsMgr_btn.Size = new Size(200, 72);
            accountsMgr_btn.TabIndex = 12;
            accountsMgr_btn.TabStop = false;
            accountsMgr_btn.Text = "Accounts Manager";
            accountsMgr_btn.UseMnemonic = false;
            accountsMgr_btn.UseVisualStyleBackColor = false;
            // 
            // signOut_btn
            // 
            signOut_btn.BackColor = Color.FromArgb(18, 18, 18);
            signOut_btn.BackgroundImageLayout = ImageLayout.Center;
            signOut_btn.Cursor = Cursors.Hand;
            signOut_btn.FlatAppearance.BorderSize = 0;
            signOut_btn.FlatStyle = FlatStyle.Flat;
            signOut_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signOut_btn.ForeColor = Color.White;
            signOut_btn.Image = (Image)resources.GetObject("signOut_btn.Image");
            signOut_btn.ImageAlign = ContentAlignment.MiddleLeft;
            signOut_btn.Location = new Point(0, 288);
            signOut_btn.Margin = new Padding(0);
            signOut_btn.Name = "signOut_btn";
            signOut_btn.Padding = new Padding(28, 0, 0, 0);
            signOut_btn.Size = new Size(200, 72);
            signOut_btn.TabIndex = 13;
            signOut_btn.TabStop = false;
            signOut_btn.Text = "Sign Out";
            signOut_btn.UseMnemonic = false;
            signOut_btn.UseVisualStyleBackColor = false;
            signOut_btn.Click += signOut_btn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(3, 363);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 327);
            panel5.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 296);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 14;
            label3.Text = "DeanDEV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 279);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 17);
            label2.TabIndex = 13;
            label2.Text = "Copyright CodeBlackSolutions";
            // 
            // systemTimeText
            // 
            systemTimeText.AutoSize = true;
            systemTimeText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemTimeText.ForeColor = Color.White;
            systemTimeText.Location = new Point(742, 691);
            systemTimeText.Margin = new Padding(4, 0, 4, 0);
            systemTimeText.Name = "systemTimeText";
            systemTimeText.Size = new Size(147, 31);
            systemTimeText.TabIndex = 9;
            systemTimeText.Text = "System Time:";
            systemTimeText.Click += label4_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // systime
            // 
            systime.AutoSize = true;
            systime.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systime.ForeColor = Color.White;
            systime.Location = new Point(897, 691);
            systime.Margin = new Padding(4, 0, 4, 0);
            systime.Name = "systime";
            systime.Size = new Size(67, 31);
            systime.TabIndex = 10;
            systime.Text = "00:00";
            systime.Click += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(677, 722);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 31);
            label1.TabIndex = 11;
            label1.Text = "Account Expiration:";
            // 
            // expirationDate
            // 
            expirationDate.AutoSize = true;
            expirationDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expirationDate.ForeColor = Color.White;
            expirationDate.Location = new Point(897, 722);
            expirationDate.Margin = new Padding(4, 0, 4, 0);
            expirationDate.Name = "expirationDate";
            expirationDate.Size = new Size(163, 31);
            expirationDate.TabIndex = 12;
            expirationDate.Text = "2026/1/24 3:00";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 77, 146);
            panel2.Controls.Add(activityLogHeader);
            panel2.Controls.Add(authLogsContainer);
            panel2.Location = new Point(218, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 516);
            panel2.TabIndex = 13;
            // 
            // activityLogHeader
            // 
            activityLogHeader.AutoSize = true;
            activityLogHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            activityLogHeader.ForeColor = Color.White;
            activityLogHeader.Location = new Point(12, 19);
            activityLogHeader.Margin = new Padding(4, 0, 4, 0);
            activityLogHeader.Name = "activityLogHeader";
            activityLogHeader.Size = new Size(165, 31);
            activityLogHeader.TabIndex = 12;
            activityLogHeader.Text = "Access Activity";
            // 
            // authLogsContainer
            // 
            authLogsContainer.BackColor = Color.FromArgb(20, 20, 20);
            authLogsContainer.Font = new Font("SimSun-ExtG", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authLogsContainer.ForeColor = Color.Teal;
            authLogsContainer.Location = new Point(11, 53);
            authLogsContainer.Name = "authLogsContainer";
            authLogsContainer.ReadOnly = true;
            authLogsContainer.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
            authLogsContainer.Size = new Size(254, 453);
            authLogsContainer.TabIndex = 0;
            authLogsContainer.Text = "";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(14, 77, 146);
            panel3.Controls.Add(encryptActivityheader);
            panel3.Controls.Add(encryptionLogsContainer);
            panel3.Location = new Point(521, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 516);
            panel3.TabIndex = 14;
            // 
            // encryptActivityheader
            // 
            encryptActivityheader.AutoSize = true;
            encryptActivityheader.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            encryptActivityheader.ForeColor = Color.White;
            encryptActivityheader.Location = new Point(12, 19);
            encryptActivityheader.Margin = new Padding(4, 0, 4, 0);
            encryptActivityheader.Name = "encryptActivityheader";
            encryptActivityheader.Size = new Size(205, 31);
            encryptActivityheader.TabIndex = 12;
            encryptActivityheader.Text = "Encryption Activity";
            encryptActivityheader.Click += encryptActivityheader_Click;
            // 
            // encryptionLogsContainer
            // 
            encryptionLogsContainer.BackColor = Color.FromArgb(20, 20, 20);
            encryptionLogsContainer.Font = new Font("SimSun-ExtG", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            encryptionLogsContainer.ForeColor = Color.Teal;
            encryptionLogsContainer.Location = new Point(12, 53);
            encryptionLogsContainer.Name = "encryptionLogsContainer";
            encryptionLogsContainer.ReadOnly = true;
            encryptionLogsContainer.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
            encryptionLogsContainer.Size = new Size(254, 453);
            encryptionLogsContainer.TabIndex = 0;
            encryptionLogsContainer.Text = " ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(14, 77, 146);
            panel4.Controls.Add(processActivityHeader);
            panel4.Controls.Add(processLogsContainer);
            panel4.Location = new Point(825, 103);
            panel4.Name = "panel4";
            panel4.Size = new Size(280, 516);
            panel4.TabIndex = 14;
            // 
            // processActivityHeader
            // 
            processActivityHeader.AutoSize = true;
            processActivityHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            processActivityHeader.ForeColor = Color.White;
            processActivityHeader.Location = new Point(12, 19);
            processActivityHeader.Margin = new Padding(4, 0, 4, 0);
            processActivityHeader.Name = "processActivityHeader";
            processActivityHeader.Size = new Size(173, 31);
            processActivityHeader.TabIndex = 12;
            processActivityHeader.Text = "Process Activity";
            // 
            // processLogsContainer
            // 
            processLogsContainer.BackColor = Color.FromArgb(20, 20, 20);
            processLogsContainer.Font = new Font("SimSun-ExtG", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            processLogsContainer.ForeColor = Color.Teal;
            processLogsContainer.Location = new Point(12, 53);
            processLogsContainer.Name = "processLogsContainer";
            processLogsContainer.ReadOnly = true;
            processLogsContainer.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
            processLogsContainer.Size = new Size(254, 453);
            processLogsContainer.TabIndex = 0;
            processLogsContainer.Text = " ";
            // 
            // updateProcess
            // 
            updateProcess.Interval = 5000;
            updateProcess.Tick += updateProcess_Tick;
            // 
            // WinLock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1140, 765);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(expirationDate);
            Controls.Add(label1);
            Controls.Add(systime);
            Controls.Add(systemTimeText);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "WinLock";
            Text = "WinLOCK";
            Load += WinLock_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label WinLockLabel;
        private Panel panel1;
        private PictureBox logo;
        private FlowLayoutPanel sidebar;
        private Button decryptButton;
        private Label userRole;
        private Label username;
        private PictureBox pictureBox1;
        private Label systemTimeText;
        private Button button1;
        private Button serviceMgr_btn;
        public Button accountsMgr_btn;
        private System.Windows.Forms.Timer timer1;
        private Label systime;
        private Button signOut_btn;
        private Label label1;
        private Label expirationDate;
        private Panel panel2;
        private RichTextBox authLogsContainer;
        private Label activityLogHeader;
        private Panel panel3;
        private Label encryptActivityheader;
        private RichTextBox encryptionLogsContainer;
        private Panel panel4;
        private Label processActivityHeader;
        private RichTextBox processLogsContainer;
        private Panel panel5;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer updateProcess;
    }
}
