namespace com.codeBlack.winLock
{
    partial class WinLock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinLock));
            encryptButton = new Button();
            textBox1 = new TextBox();
            decryptButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // encryptButton
            // 
            encryptButton.BackColor = Color.FromArgb(0, 0, 64);
            encryptButton.ForeColor = Color.White;
            encryptButton.Location = new Point(577, 134);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(203, 93);
            encryptButton.TabIndex = 0;
            encryptButton.Text = "EncryptFile";
            encryptButton.UseVisualStyleBackColor = false;
            encryptButton.Click += encryptButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 1;
            // 
            // decryptButton
            // 
            decryptButton.BackColor = Color.FromArgb(0, 0, 64);
            decryptButton.BackgroundImageLayout = ImageLayout.Center;
            decryptButton.ForeColor = Color.White;
            decryptButton.Location = new Point(577, 250);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(203, 104);
            decryptButton.TabIndex = 2;
            decryptButton.Text = "DecryptFile";
            decryptButton.UseVisualStyleBackColor = false;
            decryptButton.Click += decryptButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(338, 170);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 3;
            label1.Text = "Decryption Key:";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(136, 29);
            label2.Name = "label2";
            label2.Size = new Size(195, 28);
            label2.TabIndex = 5;
            label2.Text = "Code Black Solutions";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(127, 57);
            label3.Name = "label3";
            label3.Size = new Size(283, 81);
            label3.TabIndex = 6;
            label3.Text = "WinLOCK";
            // 
            // WinLock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(833, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(decryptButton);
            Controls.Add(textBox1);
            Controls.Add(encryptButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "WinLock";
            Text = "WinLOCK";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button encryptButton;
        private TextBox textBox1;
        private Button decryptButton;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
    }
}
