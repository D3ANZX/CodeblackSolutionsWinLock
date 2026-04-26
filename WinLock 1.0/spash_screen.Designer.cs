namespace com.codeBlack.winLock
{
    partial class spash_screen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spash_screen));
            splash_timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // splash_timer
            // 
            splash_timer.Enabled = true;
            splash_timer.Interval = 1000;
            // 
            // spash_screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(924, 503);
            ControlBox = false;
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "spash_screen";
            Text = "spash_screen";
            Load += spash_screen_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer splash_timer;
    }
}