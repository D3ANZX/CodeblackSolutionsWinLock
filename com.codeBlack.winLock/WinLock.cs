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
        string SrcFolder = @"c:\WinLockFiles\";
        string line;
        int procCount = 0;
        const string salt = "winLock";
        const int iterations = 1000;
        static public string accountHolderName = "";
        static public string role = "";
        public string activity ="";
        string authFilePath = "";
        string password = "";
        private Encryption new_enc = new Encryption();
        

        public WinLock(string accountHolderName, string role, string authFilePath, string password)
        {
            InitializeComponent();            
            userRole.Text = role;
            username.Text = accountHolderName;
            Logging new_log = new Logging(accountHolderName, role);

            new_log.logProcessActivity();
            new_log.readAuthActivity();
            new_log.readCryptActivity();
            new_log.readActivity();
            authLogsContainer.Text = new_log.authLogsContainerText;
            encryptionLogsContainer.Text = new_log.encryptionLogsContainerText;
            processLogsContainer.Text = new_log.processLogsContainerText;

            if (role != "administrator")
            {
                accountsMgr_btn.Enabled = false;
            }

            
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            using (var inputForm = new encryptionKeyInputForm())
            {
                Logging logEncrypt = new Logging(accountHolderName, role);
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
 
                    OpenFileDialog _encryptOpenFileDialog = new OpenFileDialog();
                    _encryptOpenFileDialog.InitialDirectory = SrcFolder;
                    _encryptOpenFileDialog.ShowDialog();
                    /*
                    if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {


                            new_enc.EncryptFile(_encryptOpenFileDialog.FileName, password, salt, iterations);
                            activity = "[Ecryption]";

                            logEncrypt.logCryptActivity(activity);
                            logEncrypt.readCryptActivity();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured");
                        }

                    }
                    */
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
            OpenFileDialog d = new OpenFileDialog();
            
            d.ShowDialog();

        }

    }
}
