using System.Security.Cryptography;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using com.codeBlack.winLock.Controller;
using System.Runtime.InteropServices.Marshalling;
using System.DirectoryServices;

namespace com.codeBlack.winLock
{
    public partial class WinLock : Form
    {
        const string SrcFolder = @"c:\WinLockFiles";
        string line;
        int procCount = 0;
        const string salt = "winLock";
        const int iterations = 1000;
        static public string accountHolderName = "";
        static public string role = "";
        public string activity ="";
        string authFilePath = "";
        string password;
        private Encryption new_enc = new Encryption();
        

        public WinLock(string accountHolderName, string role, string authFilePath)
        {
            InitializeComponent();            
            userRole.Text = role;
            username.Text = accountHolderName;
            Logging new_log = new Logging(accountHolderName, role);

            new_log.logProcessActivity();
            new_log.readAuthActivity();
            new_log.readCryptActivity();
            new_log.readActivity();
            if (role != "administrator")
            {
                accountsMgr_btn.Enabled = false;
            }

            
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
                        new_enc.DecryptFile(_encryptOpenFileDialog.FileName, password, salt, iterations);
                        activity = "[Ecryption]";
                        Logging logEncrypt = new Logging(accountHolderName, role);
                        logEncrypt.logCryptActivity(activity);
                        logEncrypt.readCryptActivity();
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
                    Logging logDecrypt = new Logging(accountHolderName, role);
                    logDecrypt.logCryptActivity(activity);
                    logDecrypt.readCryptActivity();
                }
                else
                {
                    MessageBox.Show("Please enter your key");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            systime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void signOut_btn_Click(object sender, EventArgs e)
        {
            procCount = 0;      
            Application.Restart();

        }

    }
}
