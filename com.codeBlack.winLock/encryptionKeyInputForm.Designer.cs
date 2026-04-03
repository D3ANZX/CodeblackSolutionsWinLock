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
            encryptionKeyField.Location = new Point(272, 239);
            encryptionKeyField.Margin = new Padding(4, 4, 4, 4);
            encryptionKeyField.Name = "encryptionKeyField";
            encryptionKeyField.Size = new Size(448, 27);
            encryptionKeyField.TabIndex = 0;
            encryptionKeyField.TextAlign = HorizontalAlignment.Center;
            encryptionKeyField.TextChanged += encryptionKeyField_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(289, 183);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(431, 41);
            label1.TabIndex = 1;
            label1.Text = "ENTER YOUR ENCRYPTION KEY";
            // 
            // confirm
            // 
            confirm.DialogResult = DialogResult.OK;
            confirm.Location = new Point(397, 289);
            confirm.Margin = new Padding(4, 4, 4, 4);
            confirm.Name = "confirm";
            confirm.Size = new Size(188, 59);
            confirm.TabIndex = 2;
            confirm.Text = "Confirm";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // encryptionKeyInputForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(982, 553);
            Controls.Add(confirm);
            Controls.Add(label1);
            Controls.Add(encryptionKeyField);
            Margin = new Padding(4, 4, 4, 4);
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