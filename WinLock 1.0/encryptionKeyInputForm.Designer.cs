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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(encryptionKeyInputForm));
            encryptionKeyField = new TextBox();
            label1 = new Label();
            confirm = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // encryptionKeyField
            // 
            encryptionKeyField.Location = new Point(149, 74);
            encryptionKeyField.Margin = new Padding(4);
            encryptionKeyField.Name = "encryptionKeyField";
            encryptionKeyField.Size = new Size(170, 27);
            encryptionKeyField.TabIndex = 0;
            encryptionKeyField.TextAlign = HorizontalAlignment.Center;
            encryptionKeyField.TextChanged += encryptionKeyField_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(14, 77, 146);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 28);
            label1.TabIndex = 1;
            label1.Text = "WinLOCK Encryption Service";
            label1.Click += label1_Click;
            // 
            // confirm
            // 
            confirm.BackColor = Color.White;
            confirm.DialogResult = DialogResult.OK;
            confirm.FlatAppearance.BorderSize = 0;
            confirm.FlatStyle = FlatStyle.Flat;
            confirm.Location = new Point(202, 109);
            confirm.Margin = new Padding(4);
            confirm.Name = "confirm";
            confirm.Size = new Size(117, 31);
            confirm.TabIndex = 2;
            confirm.Text = "Confirm";
            confirm.UseVisualStyleBackColor = false;
            confirm.Click += confirm_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 77, 146);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(confirm);
            panel1.Controls.Add(encryptionKeyField);
            panel1.Location = new Point(29, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 162);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(14, 77, 146);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 3;
            label2.Text = "Encryption Key:";
            // 
            // encryptionKeyInputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(619, 363);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "encryptionKeyInputForm";
            Text = "encryptionKeyInputForm";
            Load += encryptionKeyInputForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public TextBox encryptionKeyField;
        private Label label1;
        private Button confirm;
        private Panel panel1;
        private Label label2;
    }
}