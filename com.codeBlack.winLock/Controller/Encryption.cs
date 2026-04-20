using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace com.codeBlack.winLock.Controller
{
    public class Encryption
    {
        private const string EncrFolder = @"C:\WinLockFiles\Encrypted";
        private const string DecrFolder = @"C:\WinLockFiles\Decrypted";
        private const string padLock = ".winlock";

        public void EncryptFile(string file, string password, string salt, int iterations)
        {
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
            byte[] key = Rfc2898DeriveBytes.Pbkdf2(password, saltBytes, iterations, HashAlgorithmName.SHA256, 32);

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = key;
                aes.GenerateIV(); // Generate unique IV

                if (!Directory.Exists(EncrFolder)) Directory.CreateDirectory(EncrFolder);
                string outputPath = Path.Combine(EncrFolder, Path.GetFileName(file) + padLock);

                using (FileStream fsOutput = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                {
                    // 1. Write IV to the start of the output file
                    fsOutput.Write(aes.IV, 0, aes.IV.Length);

                    // 2. Encrypt the data
                    using (ICryptoTransform encryptor = aes.CreateEncryptor())
                    using (CryptoStream cs = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                    {
                        using (FileStream fsInput = new FileStream(file, FileMode.Open, FileAccess.Read))
                        {
                            fsInput.CopyTo(cs);
                        }
                        // Explicitly flush the final block (the padding)
                        cs.FlushFinalBlock();
                    }
                }
            }
            MessageBox.Show("Encryption Complete");
        }

        public void DecryptFile(string filePath, string password, string salt, int iterations)
        {
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
            byte[] key = Rfc2898DeriveBytes.Pbkdf2(password, saltBytes, iterations, HashAlgorithmName.SHA256, 32);

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = key;

                if (!Directory.Exists(DecrFolder)) Directory.CreateDirectory(DecrFolder);
                string outPath = Path.Combine(DecrFolder, Path.GetFileName(filePath).Replace(padLock, ""));

                using (FileStream fsInput = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // 1. Read the IV from the start of the file
                    byte[] iv = new byte[16];
                    if (fsInput.Read(iv, 0, 16) < 16) throw new Exception("File too short to be encrypted.");
                    aes.IV = iv;

                    // 2. Decrypt the remaining data
                    using (ICryptoTransform decryptor = aes.CreateDecryptor())
                    // IMPORTANT: Note we wrap the INPUT stream here for reading
                    using (CryptoStream cs = new CryptoStream(fsInput, decryptor, CryptoStreamMode.Read))
                    using (FileStream fsOutput = new FileStream(outPath, FileMode.Create, FileAccess.Write))
                    {
                        cs.CopyTo(fsOutput);
                    }
                }
            }
            MessageBox.Show("Decryption Complete");
        }

       
    }
}