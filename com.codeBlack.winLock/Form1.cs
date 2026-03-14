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
        const string salt = "winLock";
        const int iterations = 1000;
        string password;
        //Create an instance of the Encryption module
        private Encryption new_enc = new Encryption();

        public WinLock()
        {
            InitializeComponent();
        }





        private void encryptButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog _encryptOpenFileDialog = new OpenFileDialog();
            _encryptOpenFileDialog.InitialDirectory = SrcFolder;
            getEncryptionKey();
            if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                new_enc.EncryptFile(_encryptOpenFileDialog.FileName, password, salt, iterations);
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog _encryptOpenFileDialog = new OpenFileDialog();
            _encryptOpenFileDialog.InitialDirectory = SrcFolder;
            getEncryptionKey();
            if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                new_enc.DecryptFile(_encryptOpenFileDialog.FileName, password, salt, iterations);
            }
        }


        public void getEncryptionKey()
        {
            using (var inputForm = new encryptionKeyInputForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    password = inputForm.Text;
                }
                else
                {
                    MessageBox.Show("Please enter your key");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer.Text = DateTime.Now.ToString("HH:mm:ss"); ;
        }
    }
}
