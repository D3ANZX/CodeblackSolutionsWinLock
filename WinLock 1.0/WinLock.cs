using System;
using System.Windows.Forms;
using com.codeBlack.winLock.Controller;

namespace com.codeBlack.winLock
{
    public partial class WinLock : Form
    {
        string SrcFolder = @"c:\WinLockFiles\";
        const string salt = "winLock";
        const int iterations = 1000;

        public static string accountHolderName = "";
        public static string role = "";
        public static string accountExpiry;

        private Encryption new_enc = new Encryption();

        // ================= SESSION TRACKING =================
        private DateTime loginStartTime;
        private TimeSpan currentSessionDuration;
        public string finalSessionDuration = "";

        public WinLock(string accountHolderName, string role, string authFilePath, string password, string expiresAt)
        {
            InitializeComponent();
            loginStartTime = DateTime.Now;

            WinLock.accountHolderName = accountHolderName;
            WinLock.role = role;
            accountExpiry = expiresAt;

            username.Text = accountHolderName;
            userRole.Text = role;

            if (DateTime.TryParse(expiresAt, out DateTime parsedExpiry))
                expirationDate.Text = parsedExpiry.ToString("yyyy-MM-dd HH:mm:ss");
            else
                expirationDate.Text = "N/A";

            Logging log = new Logging(accountHolderName, role);

            log.logProcessActivity();
            log.readAuthActivity();
            log.readCryptActivity();
            log.readActivity();


            authLogsContainer.Text = log.authLogsContainerText;
            encryptionLogsContainer.Text = log.encryptionLogsContainerText;
            processLogsContainer.Text = log.processLogsContainerText;

            if (role != "administrator")
                accountsMgr_btn.Enabled = false;

            ShowPanel("access");
        }

        // ================= PANEL SWITCHING =================
        private void ShowPanel(string panel)
        {
            accessActivityPanel.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            accessLogsBtn.BackColor = Color.FromArgb(18, 18, 18);
            encryptLogsBtn.BackColor = Color.FromArgb(18, 18, 18);
            processLogsBtn.BackColor = Color.FromArgb(18, 18, 18);

            switch (panel)
            {
                case "access":
                    accessActivityPanel.Visible = true;
                    accessLogsBtn.BackColor = Color.FromArgb(40, 40, 40);
                    break;

                case "encrypt":
                    panel3.Visible = true;
                    encryptLogsBtn.BackColor = Color.FromArgb(40, 40, 40);
                    break;

                case "process":
                    panel4.Visible = true;
                    processLogsBtn.BackColor = Color.FromArgb(40, 40, 40);
                    break;
            }
        }

        private void accessLogsBtn_Click(object sender, EventArgs e) => ShowPanel("access");
        private void encryptLogsBtn_Click(object sender, EventArgs e) => ShowPanel("encrypt");
        private void processLogsBtn_Click(object sender, EventArgs e) => ShowPanel("process");

        // ================= TIMER =================
        private void timer1_Tick(object sender, EventArgs e)
        {
            systime.Text = DateTime.Now.ToString("HH:mm:ss");

            currentSessionDuration = DateTime.Now - loginStartTime;
            usageTime.Text = currentSessionDuration.ToString(@"hh\:mm\:ss");
        }

        // ================= ENCRYPT =================
        private void encryptButton_Click(object sender, EventArgs e)
        {
            using (var inputForm = new encryptionKeyInputForm())
            {
                Logging logEncrypt = new Logging(accountHolderName, role);

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.InitialDirectory = SrcFolder;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            new_enc.EncryptFile(dialog.FileName, inputForm.encryption_key, salt, iterations);

                            logEncrypt.logCryptActivity("[Encryption]");
                            logEncrypt.readCryptActivity();

                            encryptionLogsContainer.Text = logEncrypt.encryptionLogsContainerText;
                        }
                        catch
                        {
                            MessageBox.Show("Encryption failed.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your key");
                }
            }
        }

        // ================= DECRYPT =================
        private void decryptButton_Click(object sender, EventArgs e)
        {
            using (var inputForm = new encryptionKeyInputForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.InitialDirectory = SrcFolder;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        new_enc.DecryptFile(dialog.FileName, inputForm.encryption_key, salt, iterations);

                        Logging logDecrypt = new Logging(accountHolderName, role);
                        logDecrypt.logCryptActivity("[Decryption]");
                        logDecrypt.readCryptActivity();

                        encryptionLogsContainer.Text = logDecrypt.encryptionLogsContainerText;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your key");
                }
            }
        }

        // ================= ACCOUNT MANAGER =================
        private void accountsManagerBtnClicked(object sender, EventArgs e)
        {
            AccountsManager accMgr = new AccountsManager();
            accMgr.ShowDialog();
        }

        // ================= LOGOUT =================
        public void signOut_btn_Click(object sender, EventArgs e)
        {
            DateTime end = DateTime.Now;
            TimeSpan duration = end - loginStartTime;

            finalSessionDuration = duration.ToString(@"hh\:mm\:ss");

            Logging log = new Logging(accountHolderName, role);
            log.logSessionActivity(loginStartTime, end, duration);

            MessageBox.Show(
                $"User: {accountHolderName}\nStart: {loginStartTime}\nEnd: {end}\nDuration: {finalSessionDuration}"
            );

            Application.Restart();
        }

        private void WinLock_Load(object sender, EventArgs e)
        {
            ShowPanel("access");
        }

        private void accessActivityPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}