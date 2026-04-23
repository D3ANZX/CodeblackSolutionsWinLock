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
            accountList = new ListBox();
            accountEditTitle = new TextBox();
            passwordTBox = new TextBox();
            newPasswordTBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            expirationDateTitle = new Label();
            saveButton = new Button();
            resetButton = new Button();
            label1 = new Label();
            label2 = new Label();
            userTBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // accountList
            // 
            accountList.FormattingEnabled = true;
            accountList.Location = new Point(39, 76);
            accountList.Name = "accountList";
            accountList.Size = new Size(323, 424);
            accountList.TabIndex = 0;
            accountList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // accountEditTitle
            // 
            accountEditTitle.BackColor = Color.FromArgb(14, 77, 146);
            accountEditTitle.BorderStyle = BorderStyle.None;
            accountEditTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountEditTitle.ForeColor = Color.White;
            accountEditTitle.Location = new Point(39, 32);
            accountEditTitle.Name = "accountEditTitle";
            accountEditTitle.Size = new Size(339, 31);
            accountEditTitle.TabIndex = 1;
            accountEditTitle.Text = "SELECT AN ACCOUT TO MODIFY";
            // 
            // passwordTBox
            // 
            passwordTBox.Location = new Point(526, 191);
            passwordTBox.Name = "passwordTBox";
            passwordTBox.Size = new Size(250, 27);
            passwordTBox.TabIndex = 2;
            // 
            // newPasswordTBox
            // 
            newPasswordTBox.Location = new Point(526, 224);
            newPasswordTBox.Name = "newPasswordTBox";
            newPasswordTBox.Size = new Size(250, 27);
            newPasswordTBox.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(526, 261);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // expirationDateTitle
            // 
            expirationDateTitle.AutoSize = true;
            expirationDateTitle.ForeColor = Color.White;
            expirationDateTitle.Location = new Point(422, 261);
            expirationDateTitle.Name = "expirationDateTitle";
            expirationDateTitle.Size = new Size(98, 20);
            expirationDateTitle.TabIndex = 5;
            expirationDateTitle.Text = "EXPIRY DATE:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(682, 304);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 6;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(571, 304);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 7;
            resetButton.Text = "RESET";
            resetButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(393, 227);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 8;
            label1.Text = "NEW PASSWORD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(430, 194);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 9;
            label2.Text = "PASSWORD:";
            // 
            // userTBox
            // 
            userTBox.Location = new Point(526, 158);
            userTBox.Name = "userTBox";
            userTBox.Size = new Size(250, 27);
            userTBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(430, 165);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 11;
            label3.Text = "USERNAME:";
            // 
            // AccountsManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 77, 146);
            ClientSize = new Size(851, 536);
            Controls.Add(label3);
            Controls.Add(userTBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resetButton);
            Controls.Add(saveButton);
            Controls.Add(expirationDateTitle);
            Controls.Add(dateTimePicker1);
            Controls.Add(newPasswordTBox);
            Controls.Add(passwordTBox);
            Controls.Add(accountEditTitle);
            Controls.Add(accountList);
            Name = "AccountsManager";
            Text = "AccountsManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox accountList;
        private TextBox accountEditTitle;
        private TextBox passwordTBox;
        private TextBox newPasswordTBox;
        private DateTimePicker dateTimePicker1;
        private Label expirationDateTitle;
        private Button saveButton;
        private Button resetButton;
        private Label label1;
        private Label label2;
        private TextBox userTBox;
        private Label label3;
    }
}