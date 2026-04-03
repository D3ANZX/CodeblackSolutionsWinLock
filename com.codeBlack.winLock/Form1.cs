using System.Security.Cryptography;
using System;
using System.IO;
using System.Text;
using com.codeBlack.winLock.Controller;
using System.Runtime.InteropServices.Marshalling;
using System.DirectoryServices;

namespace com.codeBlack.winLock
{
    public partial class WinLock : Form
    {
        const string SrcFolder = @"c:\Desktop\";
        const string cryptFolder = @"c:\WinLockFiles\cryptLogs";
        const string encryptLogs = @"c:\WinLockFiles\cryptLogs\encryptLogs.txt";
        const string salt = "winLock";
        private string activity;
        const int iterations = 1000;
        bool isAdmin = false;
        string password;
        //Create an instance of the Encryption module
        private Encryption new_enc = new Encryption();

        public WinLock(string accountHolderName, string role, string authFilePath)
        {
            InitializeComponent();
            userRole.Text = role;
            username.Text = accountHolderName;
            if (role != "administrator")
            {
                accountsMgr_btn.Enabled = false;
            }
            if (!Directory.Exists(cryptFolder))
            {
                Directory.CreateDirectory(cryptFolder);
                using (FileStream encryptedFile = new FileStream(encryptLogs, FileMode.Create)) ;
            }

            using (StreamReader readAuthActivity = new StreamReader(authFilePath))
            {
                activityLogs.Text = readAuthActivity.ReadToEnd();
            }

            readCryptActivity();


        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            using (var inputForm = new encryptionKeyInputForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {

                    password = inputForm.Text;
                    OpenFileDialog _encryptOpenFileDialog = new OpenFileDialog();
                    _encryptOpenFileDialog.InitialDirectory = SrcFolder;
                    if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        new_enc.EncryptFile(_encryptOpenFileDialog.FileName, password, salt, iterations);
                        activity = "[Ecryption]";
                        logCryptActivity();
                        readCryptActivity();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your key");
                }
            }

        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            using (var inputForm = new encryptionKeyInputForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    password = inputForm.Text;
                    OpenFileDialog _encryptOpenFileDialog = new OpenFileDialog();
                    _encryptOpenFileDialog.InitialDirectory = SrcFolder;
                    if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        new_enc.DecryptFile(_encryptOpenFileDialog.FileName, password, salt, iterations);
                    }

                    activity = "[Decryption]";
                    logCryptActivity();
                    readCryptActivity();
                }
                else
                {
                    MessageBox.Show("Please enter your key");
                }
            }
        }

        private void logCryptActivity()
        {
            using (StreamWriter encryptWriter = new StreamWriter(encryptLogs, true))
            {
                encryptWriter.WriteLine($"{activity}: {username.Text} : {userRole.Text} at {DateTime.Now}");
            }
        }

        public void readCryptActivity()
        {
            using (StreamReader readCryptActivity = new StreamReader(encryptLogs))
            {
                encryptionLogs.Text = readCryptActivity.ReadToEnd();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer.Text = DateTime.Now.ToString("HH:mm:ss"); ;
        }

        private void WinLock_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void signOut_btn_Click(object sender, EventArgs e)
        {

            Application.Restart();

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
