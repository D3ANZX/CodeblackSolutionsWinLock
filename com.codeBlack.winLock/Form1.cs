using System.Security.Cryptography;
using System;
using System.IO;
using System.Text;
using com.codeBlack.winLock.Controller;
using System.Runtime.InteropServices.Marshalling;


namespace com.codeBlack.winLock
{
    public partial class WinLock : Form
    {
        const string SrcFolder = @"c:\Desktop\";
        const string salt = "winLock";
        const int iterations = 1000;
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
                if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
                {   
                    new_enc.EncryptFile(_encryptOpenFileDialog.FileName, textBox1.Text, salt, iterations);
                }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog _encryptOpenFileDialog = new OpenFileDialog();
            _encryptOpenFileDialog.InitialDirectory = SrcFolder;
                if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
                {   
                    new_enc.DecryptFile(_encryptOpenFileDialog.FileName, textBox1.Text, salt, iterations);
                }
        }



        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
