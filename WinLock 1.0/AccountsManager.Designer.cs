namespace com.codeBlack.winLock
{
    partial class AccountsManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsManager));
            accountList = new ListBox();
            accountEditTitle = new TextBox();
            passwordTBox = new TextBox();
            newPasswordTBox = new TextBox();
            expiryPicker = new DateTimePicker();
            expirationDateTitle = new Label();
            saveButton = new Button();
            label1 = new Label();
            label2 = new Label();
            userTBox = new TextBox();
            label3 = new Label();
            addAccountBtn = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            button2 = new Button();
            enabledCheckBox = new CheckBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // accountList
            // 
            accountList.FormattingEnabled = true;
            accountList.Location = new Point(23, 99);
            accountList.Name = "accountList";
            accountList.Size = new Size(456, 144);
            accountList.TabIndex = 0;
            accountList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // accountEditTitle
            // 
            accountEditTitle.BackColor = Color.FromArgb(14, 77, 146);
            accountEditTitle.BorderStyle = BorderStyle.None;
            accountEditTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountEditTitle.ForeColor = Color.White;
            accountEditTitle.Location = new Point(23, 28);
            accountEditTitle.Name = "accountEditTitle";
            accountEditTitle.Size = new Size(339, 31);
            accountEditTitle.TabIndex = 1;
            accountEditTitle.Text = "WinLock Accounts Manager";
            // 
            // passwordTBox
            // 
            passwordTBox.Location = new Point(130, 285);
            passwordTBox.Name = "passwordTBox";
            passwordTBox.Size = new Size(250, 27);
            passwordTBox.TabIndex = 2;
            // 
            // newPasswordTBox
            // 
            newPasswordTBox.Location = new Point(130, 318);
            newPasswordTBox.Name = "newPasswordTBox";
            newPasswordTBox.Size = new Size(250, 27);
            newPasswordTBox.TabIndex = 3;
            // 
            // expiryPicker
            // 
            expiryPicker.CustomFormat = "MM-dd-yyyy HH:mm:ss";
            expiryPicker.Format = DateTimePickerFormat.Custom;
            expiryPicker.Location = new Point(130, 351);
            expiryPicker.Name = "expiryPicker";
            expiryPicker.ShowUpDown = true;
            expiryPicker.Size = new Size(250, 27);
            expiryPicker.TabIndex = 4;
            // 
            // expirationDateTitle
            // 
            expirationDateTitle.AutoSize = true;
            expirationDateTitle.ForeColor = Color.White;
            expirationDateTitle.Location = new Point(23, 356);
            expirationDateTitle.Name = "expirationDateTitle";
            expirationDateTitle.Size = new Size(98, 20);
            expirationDateTitle.TabIndex = 5;
            expirationDateTitle.Text = "EXPIRY DATE:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(386, 285);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 6;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 321);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 8;
            label1.Text = "NEW PASSWORD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 285);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 9;
            label2.Text = "PASSWORD:";
            // 
            // userTBox
            // 
            userTBox.Location = new Point(130, 252);
            userTBox.Name = "userTBox";
            userTBox.Size = new Size(250, 27);
            userTBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 255);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 11;
            label3.Text = "USERNAME:";
            // 
            // addAccountBtn
            // 
            addAccountBtn.Location = new Point(386, 250);
            addAccountBtn.Name = "addAccountBtn";
            addAccountBtn.Size = new Size(94, 29);
            addAccountBtn.TabIndex = 12;
            addAccountBtn.Text = "ADD";
            addAccountBtn.UseVisualStyleBackColor = true;
            addAccountBtn.Click += addAccountBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(enabledCheckBox);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(accountEditTitle);
            panel1.Controls.Add(expirationDateTitle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addAccountBtn);
            panel1.Controls.Add(accountList);
            panel1.Controls.Add(userTBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(passwordTBox);
            panel1.Controls.Add(newPasswordTBox);
            panel1.Controls.Add(expiryPicker);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 512);
            panel1.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(14, 77, 146);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(220, 482);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 18);
            textBox1.TabIndex = 16;
            textBox1.Text = "Copyright 2026 DeanDEV - CodeBlackSolutions";
            // 
            // button2
            // 
            button2.Location = new Point(385, 355);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += resetPasswordBtn_Click;
            // 
            // enabledCheckBox
            // 
            enabledCheckBox.AutoSize = true;
            enabledCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            enabledCheckBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enabledCheckBox.ForeColor = Color.White;
            enabledCheckBox.Location = new Point(385, 390);
            enabledCheckBox.Name = "enabledCheckBox";
            enabledCheckBox.Size = new Size(83, 27);
            enabledCheckBox.TabIndex = 14;
            enabledCheckBox.Text = "Enable";
            enabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(386, 320);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "DELETE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += deleteAccountBtn_Click;
            // 
            // AccountsManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 77, 146);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(851, 536);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AccountsManager";
            Text = "AccountsManager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox accountList;
        private TextBox accountEditTitle;
        private TextBox passwordTBox;
        private TextBox newPasswordTBox;
        private DateTimePicker expiryPicker;
        private Label expirationDateTitle;
        private Button saveButton;
        private Label label1;
        private Label label2;
        private TextBox userTBox;
        private Label label3;
        private Button addAccountBtn;
        private Panel panel1;
        private Button button1;
        private CheckBox enabledCheckBox;
        private Button button2;
        private TextBox textBox1;
    }
}