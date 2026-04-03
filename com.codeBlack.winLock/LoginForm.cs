using CsvHelper;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace com.codeBlack.winLock
{

    public partial class LoginForm : Form
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "accounts.csv");
        static string authLogPath = @"C:\WinLockFiles\Logs";
        public string authFilePath = Path.Combine(authLogPath, "authlogs.txt");
        private int maxAttempts = 3;
        string[] data;
        public string username;
        public string role;
        string password;
        bool isAdmin;
        bool loginSuccess;
        string hashedInputPassword;
        string prevUser;


        public LoginForm()
        {
            InitializeComponent();
        }

        public class user
        {
            public string username { get; set; }
            public string password { get; set; }
            public string role { get; set; }
            public bool isEnabled { get; set; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text.Trim();
            password = txtPassword.Text;
            isAdmin = false;
            hashedInputPassword = Utils.HashPassword(password);
            loginSuccess = false;
            List<user> records;


            if (!File.Exists(filePath))
            {
                MessageBox.Show("Cannot find csv file");
                return;
            }

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<user>().ToList();
                foreach (var record in records)
                {
                    if (username == record.username)
                    {
                        logAuthActivity();
                        role = record.role;
                        if (password == record.password)
                        {
                            if (record.isEnabled == false)
                            {
                                MessageBox.Show("account is disabled");
                                break;
                            }
                            loginSuccess = true;
                            break;
                        }

                        else
                        {


                            if (prevUser == username)
                            {
                                maxAttempts--;
                                MessageBox.Show("Invalid password, " + maxAttempts + " attempts left");
                                if (maxAttempts == 0)
                                {
                                    record.isEnabled = false;
                                    if (record.role != "administrator") MessageBox.Show("Account is locked, please contact administrator");
                                    maxAttempts = 3;
                                    break;
                                }
                            }
                            else if (prevUser != username)
                            {
                                maxAttempts = 3;
                            }
                            prevUser = username;

                        }
                    }

                }
            }
            if (loginSuccess)
            {
                this.DialogResult = DialogResult.OK;
                Process.Start("explorer.exe");
            }
            else
            {

            }
        }




        private void logAuthActivity()
        {
            if (!Directory.Exists(authLogPath))
            {
                Directory.CreateDirectory(authLogPath);

                using (FileStream authLogFile = new FileStream(authFilePath, FileMode.Create)) ;
            }
            using (StreamWriter authLogger = new StreamWriter(authFilePath, true))
            {
                authLogger.WriteLine($"A user at {DateTime.Now} attempted login, username is {username}");
            }

        }



        public void KillExplorerAndKeepItDead()
        {
            // 1. Tell Windows NOT to restart the shell automatically
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
            if (key != null)
            {
                key.SetValue("AutoRestartShell", 0, RegistryValueKind.DWord);
                key.Close();
            }

            // 2. Kill all explorer processes
            foreach (var process in Process.GetProcessesByName("explorer"))
            {
                process.Kill();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}