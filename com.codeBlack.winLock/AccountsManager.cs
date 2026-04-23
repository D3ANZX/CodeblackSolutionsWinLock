using System;
using System.IO;
using System.Windows.Forms;

namespace com.codeBlack.winLock
{
    class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string IsEnabled { get; set; }

        public override string ToString()
        {
            return $"{Username} | {Password} | {Role} | {IsEnabled}";
        }
    }

    public partial class AccountsManager : Form
    {
        public static string accountsPath = @"C:\WinLockFiles\env";
        string filePath = Path.Combine(accountsPath, "accounts.csv");

        public AccountsManager()
        {
            InitializeComponent();
            LoadAccounts();
        }




        private void LoadAccounts()
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    if (data.Length < 4) continue;

                    if (isHeader)
                    {
                        // Optional: skip header OR display it
                        isHeader = false;
                        continue;
                    }

                    Account acc = new Account
                    {
                        Username = data[0],
                        Password = data[1],
                        Role = data[2],
                        IsEnabled = data[3]
                    };

                    accountList.Items.Add(acc);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountList.SelectedItem != null)
            {
                Account selected = (Account)accountList.SelectedItem;

                userTBox.Text = selected.Username;
                passwordTBox.Text = selected.Password;
            }
        }
    }
}