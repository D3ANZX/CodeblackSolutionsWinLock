using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace com.codeBlack.winLock
{
    public partial class LoginForm : Form
    {
        public static string accountsPath = @"C:\WinLockFiles\env";
        public static string authLogPath = @"C:\WinLockFiles\Logs";

        string filePath = Path.Combine(accountsPath, "accounts.csv");
        public string authFilePath = Path.Combine(authLogPath, "authlogs.txt");

        private int maxAttempts = 3;

        public string username;
        public string role;

        // ✅ THIS IS WHAT YOU WANTED
        public string CurrentUserExpiryString;

        bool loginSuccess;
        public string hashedInputPassword;
        string prevUser;

        public LoginForm()
        {
            InitializeComponent();

            if (!Directory.Exists(accountsPath))
                Directory.CreateDirectory(accountsPath);

            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("username,password,role,isEnabled,expiresAt");
                    writer.WriteLine($"admin,{Utils.HashPassword("adminwinlock")},administrator,true,2099-12-31 23:59:59");
                    writer.WriteLine($"Dean,{Utils.HashPassword("adminwinlock")},administrator,true,2099-12-31 23:59:59");
                }
            }
        }

        // ================= USER MODEL =================
        public class user
        {
            public string username { get; set; }
            public string password { get; set; }
            public string role { get; set; }
            public bool isEnabled { get; set; }
            public string expiresAt { get; set; }
        }

        // ================= CSV MAP =================
        public sealed class UserMap : ClassMap<user>
        {
            public UserMap()
            {
                Map(m => m.username).Name("username");
                Map(m => m.password).Name("password");
                Map(m => m.role).Name("role");
                Map(m => m.isEnabled).Name("isEnabled");
                Map(m => m.expiresAt).Name("expiresAt");
            }
        }

        // ================= LOGIN =================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            hashedInputPassword = Utils.HashPassword(password);
            loginSuccess = false;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Cannot find accounts file");
                return;
            }

            List<user> records;

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<UserMap>();
                records = csv.GetRecords<user>().ToList();
            }

            foreach (var record in records)
            {
                if (username == record.username)
                {
                    logAuthActivity();
                    role = record.role;

                    // ================= STORE EXPIRY AS STRING =================
                    CurrentUserExpiryString = record.expiresAt;

                    // still validate internally
                    if (!DateTime.TryParse(record.expiresAt, out DateTime expiry))
                        expiry = DateTime.MaxValue;

                    if (DateTime.Now > expiry)
                    {
                        MessageBox.Show(
                            $"Account expired on {record.expiresAt}",
                            "Expired Account",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }

                    TimeSpan remaining = expiry - DateTime.Now;
                    if (remaining.TotalHours <= 72)
                    {
                        MessageBox.Show(
                            $"⚠ Expiring soon:\n{remaining.Days}d {remaining.Hours}h {remaining.Minutes}m",
                            "Expiry Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }

                    // ================= PASSWORD CHECK =================
                    if (hashedInputPassword == record.password)
                    {
                        if (!record.isEnabled)
                        {
                            MessageBox.Show("Account is disabled");
                            return;
                        }

                        loginSuccess = true;
                        break;
                    }
                    else
                    {
                        HandleFailedAttempt(record, records);
                        return;
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
                MessageBox.Show("Invalid username or password");
            }
        }

        // ================= FAIL HANDLER =================
        private void HandleFailedAttempt(user record, List<user> records)
        {
            if (prevUser == username)
                maxAttempts--;
            else
                maxAttempts = 2;

            prevUser = username;

            MessageBox.Show($"Invalid password, {maxAttempts} attempts left");

            if (maxAttempts <= 0)
            {
                record.isEnabled = false;
                SaveAll(records);

                if (record.role != "administrator")
                {
                    MessageBox.Show("Account is locked, contact administrator");
                }

                maxAttempts = 3;
            }
        }

        // ================= SAVE =================
        private void SaveAll(List<user> records)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine("username,password,role,isEnabled,expiresAt");

                foreach (var acc in records)
                {
                    writer.WriteLine(
                        $"{acc.username},{acc.password},{acc.role},{acc.isEnabled},{acc.expiresAt}"
                    );
                }
            }
        }

        // ================= LOG =================
        private void logAuthActivity()
        {
            if (!Directory.Exists(authLogPath))
                Directory.CreateDirectory(authLogPath);

            using (StreamWriter authLogger = new StreamWriter(authFilePath, true))
            {
                authLogger.WriteLine($"[{DateTime.Now}] Login attempt: {username}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public void ApplyFullLockdown()
        {
            try
            {
                // 1. Disable Auto-Restart for Explorer and Kill it
                RegistryKey winlogon = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
                winlogon.SetValue("AutoRestartShell", 0, RegistryValueKind.DWord);

                foreach (var process in Process.GetProcessesByName("explorer"))
                {
                    process.Kill();
                }

                // 2. Disable Task Manager
                RegistryKey systemPolicy = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                systemPolicy.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);

                // 3. Disable the Run Command (Win+R)
                RegistryKey explorerPolicy = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer");
                explorerPolicy.SetValue("NoRun", 1, RegistryValueKind.DWord);

                MessageBox.Show("Welcome! Please login to WinLock to continue using your computer.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Ensure you are running as Administrator. " + ex.Message);
            }
        }
    }
}