using System.Security.Cryptography;
using System;
using System.IO;
using System.Text;


namespace com.codeBlack.winLock
{
    public partial class WinLock : Form
    {
        const string EncrFolder = @"c:\EncrFolder\";
        const string DecrFolder = @"c:\DecrFolder\";
        const string SrcFolder = @"c:\Desktop\";
        public WinLock()
        {
            InitializeComponent();
        }


        //Function for encryptButton Click Event
        private void encryptButton_Click(object sender, EventArgs e)
        {   //Create a new instance of OpenFile Dialog
            string salt = "test";
            int iterations = 1000;
            OpenFileDialog _encryptOpenFileDialog = new OpenFileDialog();
            _encryptOpenFileDialog.InitialDirectory = SrcFolder;

            if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
            {   //Execute the EncryptFile() function
                EncryptFile(_encryptOpenFileDialog.FileName, textBox1.Text, salt, iterations);
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string salt = "test";
            int iterations = 1000;
            OpenFileDialog _encryptOpenFileDialog = new OpenFileDialog();
            _encryptOpenFileDialog.InitialDirectory = SrcFolder;

            if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
            {   //Execute the EncryptFile() function
                DecryptFile(_encryptOpenFileDialog.FileName, textBox1.Text, salt, iterations);
            }
        }

        private void EncryptFile(string file, string password, string salt, int iterations)
        {
            //Convert string parameters to bytes
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt); //Convert salt to bytes
            byte[] key = Rfc2898DeriveBytes.Pbkdf2(password, saltBytes, iterations, HashAlgorithmName.SHA256, outputLength: 32); //set Key to R2898 Bytes

            //Create Aes objet and instance
            using (Aes aes = Aes.Create())
            {
                //Assign the RFC2898Derive Bytes value as the aes.key
                aes.Key = key;
                aes.IV = new byte[16];



                using (FileStream output = new FileStream(Path.Combine(EncrFolder, Path.ChangeExtension(file, ".enc")), FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                using (CryptoStream stream = new CryptoStream(output, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    new FileStream(file, FileMode.Open).CopyTo(stream);
                }
                MessageBox.Show("File Encrypted successfully");
            }
        }

        private void DecryptFile(string file, string password, string salt, int iterations)
        {
            //Convert string parameters to bytes
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt); //Convert salt to bytes
            byte[] key = Rfc2898DeriveBytes.Pbkdf2(password, saltBytes, iterations, HashAlgorithmName.SHA256, outputLength: 32); //set Key to R2898 Bytes

            //Create Aes objet and instance
            try
            {
                using (Aes aes = Aes.Create())
                {
                    //Assign the RFC2898Derive Bytes value as the aes.key
                    aes.Key = key;
                    aes.IV = new byte[16];

                    using (FileStream input = new FileStream(file, FileMode.Open, FileAccess.Read))
                    using (FileStream output = new FileStream(Path.Combine(EncrFolder, Path.ChangeExtension(file, ".pdf")), FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                    using (CryptoStream stream = new CryptoStream(input, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        stream.CopyTo(output);
                    }
                    MessageBox.Show("File Decrypted successfully");
                }
            }
            catch
            {
                MessageBox.Show("Invalid Key");
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
