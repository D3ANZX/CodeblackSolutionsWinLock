using System;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace com.codeBlack.winLock
{
    public partial class AccountsManager : Form
    {
        public static string accountsPath = @"C:\WinLockFiles\env";
        string filePath = Path.Combine(accountsPath, "accounts.csv");

        public AccountsManager()
        {
            InitializeComponent();

            if (!LicenseManager.UsageMode.Equals(LicenseUsageMode.Designtime))
            {
                LoadAccounts();
            }
        }

        // ================= LOAD =================
        private void LoadAccounts()
        {
            accountList.BeginUpdate();
            accountList.SelectedIndexChanged -= listBox1_SelectedIndexChanged;

            accountList.Items.Clear();

            if (!File.Exists(filePath))
            {
                accountList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
                accountList.EndUpdate();
                return;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] data = line.Split(',');

                    if (data.Length < 5) continue;

                    DateTime expiry;
                    DateTime.TryParse(data[4], out expiry);

                    accountList.Items.Add(new Account
                    {
                        Username = data[0],
                        Password = data[1],
                        Role = data[2],
                        IsEnabled = data[3],
                        ExpiresAt = expiry
                    });
                }
            }

            accountList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            accountList.EndUpdate();

            if (accountList.Items.Count > 0)
                accountList.SelectedIndex = 0;
        }

        // ================= SAVE BUTTON =================
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userTBox.Text))
            {
                MessageBox.Show("Username is required.");
                return;
            }

            if (accountList.SelectedItem is Account selected)
                UpdateAccount(selected);
            else
                AddNewAccount();
        }

        // ================= ADD =================
        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            if (accountList.SelectedItem != null)
            {
                var confirm = MessageBox.Show(
                    "You have an account selected. Add new account instead?",
                    "Confirm Add",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.No)
                    return;

                accountList.ClearSelected();
            }

            AddNewAccount();
        }

        private void AddNewAccount()
        {
            foreach (Account account in accountList.Items)
            {
                if (account.Username.Equals(userTBox.Text, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Username already exists!");
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(passwordTBox.Text))
            {
                MessageBox.Show("Password is required.");
                return;
            }

            Account acc = new Account
            {
                Username = userTBox.Text.Trim(),
                Password = Utils.HashPassword(passwordTBox.Text),
                Role = "User",
                IsEnabled = "True",
                ExpiresAt = expiryPicker.Value
            };

            AppendToFile(acc);
            accountList.Items.Add(acc);

            LoadAccounts();
            MessageBox.Show("Account added!");
            ClearInputs();
        }

        // ================= UPDATE =================
        private void UpdateAccount(Account selected)
        {
            // ONLY check password if user typed one
            if (!string.IsNullOrWhiteSpace(passwordTBox.Text))
            {
                string currentHash = Utils.HashPassword(passwordTBox.Text);

                if (selected.Password != currentHash)
                {
                    MessageBox.Show("Current password is incorrect.");
                    return;
                }
            }

            // Update password ONLY if new password entered
            if (!string.IsNullOrWhiteSpace(newPasswordTBox.Text))
            {
                selected.Password = Utils.HashPassword(newPasswordTBox.Text);
            }

            // Always update these (safe)
            selected.IsEnabled = enabledCheckBox.Checked ? "True" : "False";
            selected.ExpiresAt = expiryPicker.Value;

            SaveAllAccountsToFile();

            MessageBox.Show("Account updated!");

            ClearInputs();
            LoadAccounts();
        }

        // ================= FILE HELPERS =================
        private void AppendToFile(Account acc)
        {
            Directory.CreateDirectory(accountsPath);

            bool fileExists = File.Exists(filePath);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                if (!fileExists)
                {
                    writer.WriteLine("username,password,role,isEnabled,expiresAt");
                }

                writer.WriteLine($"{acc.Username},{acc.Password},{acc.Role},{acc.IsEnabled},{acc.ExpiresAt:yyyy-MM-dd HH:mm:ss}");
            }
        }

        private void SaveAllAccountsToFile()
        {
            Directory.CreateDirectory(accountsPath);

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine("username,password,role,isEnabled,expiresAt");

                foreach (Account acc in accountList.Items)
                {
                    writer.WriteLine($"{acc.Username},{acc.Password},{acc.Role},{acc.IsEnabled},{acc.ExpiresAt:yyyy-MM-dd HH:mm:ss}");
                }
            }
        }

        // ================= RESET PASSWORD =================
        private void resetPasswordBtn_Click(object sender, EventArgs e)
        {
            if (accountList.SelectedItem is not Account selected)
            {
                MessageBox.Show("Select an account.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newPasswordTBox.Text))
            {
                MessageBox.Show("Enter a new password.");
                return;
            }

            selected.Password = Utils.HashPassword(newPasswordTBox.Text);

            SaveAllAccountsToFile();
            LoadAccounts();

            MessageBox.Show("Password reset successful.");

            newPasswordTBox.Text = "";
        }

        // ================= DELETE =================
        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            if (accountList.SelectedItem is not Account selected)
            {
                MessageBox.Show("Select an account to delete.");
                return;
            }

            accountList.Items.Remove(selected);

            SaveAllAccountsToFile();

            MessageBox.Show("Account deleted.");
            ClearInputs();
        }

        // ================= SELECTION =================
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;

            if (accountList?.SelectedItem is Account selected)
            {
                userTBox.Text = selected.Username;
                passwordTBox.Text = "";
                newPasswordTBox.Text = "";

                enabledCheckBox.Checked = selected.IsEnabled == "True";
              
                expiryPicker.Value = selected.ExpiresAt == default
                    ? DateTime.Now.AddDays(30)
                    : selected.ExpiresAt;
            }
        }

        // ================= TOGGLE =================
        private void toggleEnableBtn_Click(object sender, EventArgs e)
        {
            if (accountList.SelectedItem is not Account selected)
            {
                MessageBox.Show("Select an account.");
                return;
            }

            selected.IsEnabled = selected.IsEnabled == "True" ? "False" : "True";

            SaveAllAccountsToFile();
            LoadAccounts();

            MessageBox.Show($"Account {(selected.IsEnabled == "True" ? "enabled" : "disabled")}");
        }

        private void ClearInputs()
        {
            userTBox.Text = "";
            passwordTBox.Text = "";
            newPasswordTBox.Text = "";
        }

        private void accountsMgrCloseWindow(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }

    class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string IsEnabled { get; set; }
        public DateTime ExpiresAt { get; set; }

        public override string ToString()
        {
            return $"{Username} | {Role} | {IsEnabled} | Expires: {ExpiresAt}";
        }
    }
}