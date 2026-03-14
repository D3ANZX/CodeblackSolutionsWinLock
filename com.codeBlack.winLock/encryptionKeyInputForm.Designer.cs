namespace com.codeBlack.winLock
{
    partial class encryptionKeyInputForm
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
            encryptionKeyField = new TextBox();
            label1 = new Label();
            confirm = new Button();
            SuspendLayout();
            // 
            // encryptionKeyField
            // 
            encryptionKeyField.Location = new Point(149, 144);
            encryptionKeyField.Name = "encryptionKeyField";
            encryptionKeyField.Size = new Size(349, 23);
            encryptionKeyField.TabIndex = 0;
            encryptionKeyField.TextChanged += encryptionKeyField_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 110);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 1;
            label1.Text = "ENTER YOUR ENCRYPTION KEY";
            // 
            // confirm
            // 
            confirm.DialogResult = DialogResult.OK;
            confirm.Location = new Point(239, 188);
            confirm.Name = "confirm";
            confirm.Size = new Size(146, 42);
            confirm.TabIndex = 2;
            confirm.Text = "Confirm";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // encryptionKeyInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 314);
            Controls.Add(confirm);
            Controls.Add(label1);
            Controls.Add(encryptionKeyField);
            Name = "encryptionKeyInputForm";
            Text = "encryptionKeyInputForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox encryptionKeyField;
        private Label label1;
        private Button confirm;
    }
}