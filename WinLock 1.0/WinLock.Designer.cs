namespace com.codeBlack.winLock
{
    partial class WinLock
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinLock));
            WinLockLabel = new Label();
            panel1 = new Panel();
            logo = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            userRole = new Label();
            username = new Label();
            accessLogsBtn = new Button();
            encryptLogsBtn = new Button();
            processLogsBtn = new Button();
            encryptBtn = new Button();
            decryptButton = new Button();
            accountsMgr_btn = new Button();
            signOut_btn = new Button();
            panel2 = new Panel();
            usageTime = new Label();
            usageDurationLabel = new Label();
            accountExpButton = new Label();
            sysTimeLabel = new Label();
            systime = new Label();
            expirationDate = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            accessActivityPanel = new Panel();
            activityLogHeader = new Label();
            authLogsContainer = new RichTextBox();
            panel3 = new Panel();
            encryptActivityheader = new Label();
            encryptionLogsContainer = new RichTextBox();
            panel4 = new Panel();
            processActivityHeader = new Label();
            processLogsContainer = new RichTextBox();
            deanDEVLabel = new Label();
            panel6 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            sidebar.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            accessActivityPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // WinLockLabel
            // 
            WinLockLabel.Font = new Font("Segoe UI", 26F);
            WinLockLabel.ForeColor = Color.White;
            WinLockLabel.Location = new Point(78, 14);
            WinLockLabel.Name = "WinLockLabel";
            WinLockLabel.Size = new Size(230, 60);
            WinLockLabel.TabIndex = 4;
            WinLockLabel.Text = "WinLOCK";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 77, 146);
            panel1.Controls.Add(logo);
            panel1.Controls.Add(WinLockLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 80);
            panel1.TabIndex = 0;
            // 
            // logo
            // 
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Location = new Point(12, 14);
            logo.Name = "logo";
            logo.Size = new Size(60, 60);
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(18, 18, 18);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(accessLogsBtn);
            sidebar.Controls.Add(encryptLogsBtn);
            sidebar.Controls.Add(processLogsBtn);
            sidebar.Controls.Add(encryptBtn);
            sidebar.Controls.Add(decryptButton);
            sidebar.Controls.Add(accountsMgr_btn);
            sidebar.Controls.Add(signOut_btn);
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 80);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 808);
            sidebar.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(userRole);
            panel5.Controls.Add(username);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 76);
            panel5.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // userRole
            // 
            userRole.BackColor = Color.Transparent;
            userRole.ForeColor = Color.White;
            userRole.Location = new Point(68, 42);
            userRole.Name = "userRole";
            userRole.RightToLeft = RightToLeft.No;
            userRole.Size = new Size(116, 25);
            userRole.TabIndex = 5;
            userRole.Text = "role";
            // 
            // username
            // 
            username.BackColor = Color.Transparent;
            username.ForeColor = Color.White;
            username.Location = new Point(68, 20);
            username.Name = "username";
            username.RightToLeft = RightToLeft.No;
            username.Size = new Size(96, 25);
            username.TabIndex = 4;
            username.Text = "username";
            // 
            // accessLogsBtn
            // 
            accessLogsBtn.FlatAppearance.BorderSize = 0;
            accessLogsBtn.FlatStyle = FlatStyle.Flat;
            accessLogsBtn.ForeColor = Color.White;
            accessLogsBtn.Location = new Point(0, 76);
            accessLogsBtn.Margin = new Padding(0);
            accessLogsBtn.Name = "accessLogsBtn";
            accessLogsBtn.Size = new Size(200, 60);
            accessLogsBtn.TabIndex = 0;
            accessLogsBtn.Text = "Access Logs";
            accessLogsBtn.Click += accessLogsBtn_Click;
            // 
            // encryptLogsBtn
            // 
            encryptLogsBtn.FlatAppearance.BorderSize = 0;
            encryptLogsBtn.FlatStyle = FlatStyle.Flat;
            encryptLogsBtn.ForeColor = Color.White;
            encryptLogsBtn.Location = new Point(0, 136);
            encryptLogsBtn.Margin = new Padding(0);
            encryptLogsBtn.Name = "encryptLogsBtn";
            encryptLogsBtn.Size = new Size(200, 60);
            encryptLogsBtn.TabIndex = 1;
            encryptLogsBtn.Text = "Encryption Logs";
            encryptLogsBtn.Click += encryptLogsBtn_Click;
            // 
            // processLogsBtn
            // 
            processLogsBtn.FlatAppearance.BorderSize = 0;
            processLogsBtn.FlatStyle = FlatStyle.Flat;
            processLogsBtn.ForeColor = Color.White;
            processLogsBtn.Location = new Point(0, 196);
            processLogsBtn.Margin = new Padding(0);
            processLogsBtn.Name = "processLogsBtn";
            processLogsBtn.Size = new Size(200, 60);
            processLogsBtn.TabIndex = 2;
            processLogsBtn.Text = "Process Logs";
            processLogsBtn.Click += processLogsBtn_Click;
            // 
            // encryptBtn
            // 
            encryptBtn.FlatAppearance.BorderSize = 0;
            encryptBtn.FlatStyle = FlatStyle.Flat;
            encryptBtn.ForeColor = Color.White;
            encryptBtn.Location = new Point(0, 256);
            encryptBtn.Margin = new Padding(0);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(200, 60);
            encryptBtn.TabIndex = 3;
            encryptBtn.Text = "Encrypt File";
            encryptBtn.Click += encryptButton_Click;
            // 
            // decryptButton
            // 
            decryptButton.FlatAppearance.BorderSize = 0;
            decryptButton.FlatStyle = FlatStyle.Flat;
            decryptButton.ForeColor = Color.White;
            decryptButton.Location = new Point(0, 316);
            decryptButton.Margin = new Padding(0);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(200, 60);
            decryptButton.TabIndex = 4;
            decryptButton.Text = "Decrypt File";
            decryptButton.Click += decryptButton_Click;
            // 
            // accountsMgr_btn
            // 
            accountsMgr_btn.FlatAppearance.BorderSize = 0;
            accountsMgr_btn.FlatStyle = FlatStyle.Flat;
            accountsMgr_btn.ForeColor = Color.White;
            accountsMgr_btn.Location = new Point(0, 376);
            accountsMgr_btn.Margin = new Padding(0);
            accountsMgr_btn.Name = "accountsMgr_btn";
            accountsMgr_btn.Size = new Size(200, 60);
            accountsMgr_btn.TabIndex = 5;
            accountsMgr_btn.Text = "Accounts Manager";
            accountsMgr_btn.Click += accountsManagerBtnClicked;
            // 
            // signOut_btn
            // 
            signOut_btn.FlatAppearance.BorderSize = 0;
            signOut_btn.FlatStyle = FlatStyle.Flat;
            signOut_btn.ForeColor = Color.White;
            signOut_btn.Location = new Point(0, 436);
            signOut_btn.Margin = new Padding(0);
            signOut_btn.Name = "signOut_btn";
            signOut_btn.Size = new Size(200, 60);
            signOut_btn.TabIndex = 6;
            signOut_btn.Text = "Sign Out";
            signOut_btn.Click += signOut_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 20, 20);
            panel2.Controls.Add(usageTime);
            panel2.Controls.Add(usageDurationLabel);
            panel2.Controls.Add(accountExpButton);
            panel2.Controls.Add(sysTimeLabel);
            panel2.Controls.Add(systime);
            panel2.Controls.Add(expirationDate);
            panel2.Location = new Point(15, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 84);
            panel2.TabIndex = 7;
            // 
            // usageTime
            // 
            usageTime.ForeColor = Color.White;
            usageTime.Location = new Point(183, 52);
            usageTime.Name = "usageTime";
            usageTime.Size = new Size(143, 23);
            usageTime.TabIndex = 9;
            usageTime.Text = "usage-time";
            // 
            // usageDurationLabel
            // 
            usageDurationLabel.BackColor = Color.Transparent;
            usageDurationLabel.ForeColor = Color.White;
            usageDurationLabel.Location = new Point(183, 27);
            usageDurationLabel.Name = "usageDurationLabel";
            usageDurationLabel.RightToLeft = RightToLeft.No;
            usageDurationLabel.Size = new Size(126, 25);
            usageDurationLabel.TabIndex = 8;
            usageDurationLabel.Text = "Usage Time:";
            // 
            // accountExpButton
            // 
            accountExpButton.BackColor = Color.Transparent;
            accountExpButton.ForeColor = Color.White;
            accountExpButton.Location = new Point(332, 27);
            accountExpButton.Name = "accountExpButton";
            accountExpButton.RightToLeft = RightToLeft.No;
            accountExpButton.Size = new Size(146, 25);
            accountExpButton.TabIndex = 7;
            accountExpButton.Text = "Valid Until:";
            // 
            // sysTimeLabel
            // 
            sysTimeLabel.BackColor = Color.Transparent;
            sysTimeLabel.ForeColor = Color.White;
            sysTimeLabel.Location = new Point(18, 27);
            sysTimeLabel.Name = "sysTimeLabel";
            sysTimeLabel.RightToLeft = RightToLeft.No;
            sysTimeLabel.Size = new Size(96, 25);
            sysTimeLabel.TabIndex = 6;
            sysTimeLabel.Text = "System Time";
            // 
            // systime
            // 
            systime.ForeColor = Color.White;
            systime.Location = new Point(18, 52);
            systime.Name = "systime";
            systime.Size = new Size(159, 23);
            systime.TabIndex = 3;
            systime.Text = "system-time";
            // 
            // expirationDate
            // 
            expirationDate.ForeColor = Color.White;
            expirationDate.Location = new Point(332, 52);
            expirationDate.Name = "expirationDate";
            expirationDate.Size = new Size(159, 23);
            expirationDate.TabIndex = 5;
            expirationDate.Text = "expiration-date";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // accessActivityPanel
            // 
            accessActivityPanel.BackColor = Color.FromArgb(14, 77, 146);
            accessActivityPanel.Controls.Add(activityLogHeader);
            accessActivityPanel.Controls.Add(authLogsContainer);
            accessActivityPanel.Location = new Point(223, 97);
            accessActivityPanel.Name = "accessActivityPanel";
            accessActivityPanel.Size = new Size(880, 520);
            accessActivityPanel.TabIndex = 6;
            accessActivityPanel.Paint += accessActivityPanel_Paint;
            // 
            // activityLogHeader
            // 
            activityLogHeader.ForeColor = Color.White;
            activityLogHeader.Location = new Point(10, 10);
            activityLogHeader.Name = "activityLogHeader";
            activityLogHeader.Size = new Size(100, 23);
            activityLogHeader.TabIndex = 0;
            activityLogHeader.Text = "Access Activity";
            // 
            // authLogsContainer
            // 
            authLogsContainer.BackColor = Color.FromArgb(20, 20, 20);
            authLogsContainer.Dock = DockStyle.Bottom;
            authLogsContainer.ForeColor = Color.White;
            authLogsContainer.Location = new Point(0, 35);
            authLogsContainer.Name = "authLogsContainer";
            authLogsContainer.ReadOnly = true;
            authLogsContainer.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            authLogsContainer.Size = new Size(880, 485);
            authLogsContainer.TabIndex = 1;
            authLogsContainer.Text = "";
            authLogsContainer.WordWrap = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(14, 77, 146);
            panel3.Controls.Add(encryptActivityheader);
            panel3.Controls.Add(encryptionLogsContainer);
            panel3.Location = new Point(217, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 520);
            panel3.TabIndex = 7;
            // 
            // encryptActivityheader
            // 
            encryptActivityheader.ForeColor = Color.White;
            encryptActivityheader.Location = new Point(10, 10);
            encryptActivityheader.Name = "encryptActivityheader";
            encryptActivityheader.Size = new Size(100, 23);
            encryptActivityheader.TabIndex = 0;
            encryptActivityheader.Text = "Encryption Activity";
            // 
            // encryptionLogsContainer
            // 
            encryptionLogsContainer.BackColor = Color.FromArgb(20, 20, 20);
            encryptionLogsContainer.Dock = DockStyle.Bottom;
            encryptionLogsContainer.ForeColor = Color.White;
            encryptionLogsContainer.Location = new Point(0, 35);
            encryptionLogsContainer.Name = "encryptionLogsContainer";
            encryptionLogsContainer.ReadOnly = true;
            encryptionLogsContainer.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            encryptionLogsContainer.Size = new Size(880, 485);
            encryptionLogsContainer.TabIndex = 1;
            encryptionLogsContainer.Text = "";
            encryptionLogsContainer.WordWrap = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(14, 77, 146);
            panel4.Controls.Add(processActivityHeader);
            panel4.Controls.Add(processLogsContainer);
            panel4.Location = new Point(220, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(880, 520);
            panel4.TabIndex = 8;
            // 
            // processActivityHeader
            // 
            processActivityHeader.ForeColor = Color.White;
            processActivityHeader.Location = new Point(10, 10);
            processActivityHeader.Name = "processActivityHeader";
            processActivityHeader.Size = new Size(100, 23);
            processActivityHeader.TabIndex = 0;
            processActivityHeader.Text = "Process Activity";
            // 
            // processLogsContainer
            // 
            processLogsContainer.BackColor = Color.FromArgb(20, 20, 20);
            processLogsContainer.Dock = DockStyle.Bottom;
            processLogsContainer.ForeColor = Color.White;
            processLogsContainer.Location = new Point(0, 36);
            processLogsContainer.Name = "processLogsContainer";
            processLogsContainer.ReadOnly = true;
            processLogsContainer.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            processLogsContainer.Size = new Size(880, 484);
            processLogsContainer.TabIndex = 1;
            processLogsContainer.Text = "";
            processLogsContainer.WordWrap = false;
            // 
            // deanDEVLabel
            // 
            deanDEVLabel.BackColor = Color.Transparent;
            deanDEVLabel.ForeColor = Color.White;
            deanDEVLabel.Location = new Point(806, 850);
            deanDEVLabel.Name = "deanDEVLabel";
            deanDEVLabel.RightToLeft = RightToLeft.No;
            deanDEVLabel.Size = new Size(322, 25);
            deanDEVLabel.TabIndex = 9;
            deanDEVLabel.Text = "Copyright 2026 CodeBlackSolutions DeanDEV";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(14, 77, 146);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(panel2);
            panel6.Location = new Point(496, 644);
            panel6.Name = "panel6";
            panel6.Size = new Size(607, 124);
            panel6.TabIndex = 11;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 2);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(125, 25);
            label1.TabIndex = 10;
            label1.Text = "WinLOCK Timer";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(14, 77, 146);
            label2.ForeColor = Color.White;
            label2.Location = new Point(217, 850);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(180, 25);
            label2.TabIndex = 12;
            label2.Text = "Photo by Gerard D. Lapuz";
            // 
            // WinLock
            // 
            BackColor = Color.FromArgb(24, 24, 24);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1140, 884);
            Controls.Add(label2);
            Controls.Add(panel6);
            Controls.Add(deanDEVLabel);
            Controls.Add(panel1);
            Controls.Add(accessActivityPanel);
            Controls.Add(panel3);
            Controls.Add(sidebar);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "WinLock";
            Text = "WinLOCK";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            sidebar.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            accessActivityPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label WinLockLabel;
        private Panel panel1;
        private PictureBox logo;
        private FlowLayoutPanel sidebar;
        private Button accessLogsBtn;
        private Button encryptLogsBtn;
        private Button processLogsBtn;
        private Button decryptButton;
        private Button encryptBtn;
        public Button accountsMgr_btn;
        private System.Windows.Forms.Timer timer1;
        private Label systime;
        private Button signOut_btn;
        private Label expirationDate;

        private Panel accessActivityPanel;
        private RichTextBox authLogsContainer;
        private Label activityLogHeader;

        private Panel panel3;
        private Label encryptActivityheader;
        private RichTextBox encryptionLogsContainer;

        private Panel panel4;
        private Label processActivityHeader;
        private RichTextBox processLogsContainer;
        private Panel panel2;
        private Label sysTimeLabel;
        private Label accountExpButton;
        private Label deanDEVLabel;
        private Label usageDurationLabel;
        private Label usageTime;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label userRole;
        private Label username;
        private Panel panel6;
        private Label label1;
        private Label label2;
    }

}

