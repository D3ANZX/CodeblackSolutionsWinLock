using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace com.codeBlack.winLock
{

    public partial class spash_screen : Form
    {
        public spash_screen()
        {
            splash_timer.Interval = 10000;
            splash_timer.Tick += splash_timer_Tick;
            splash_timer.Start();
        }

        private void splash_timer_Tick(object sender, EventArgs e)
        {
            splash_timer.Stop();

            // Show Login Form
            LoginForm login = new LoginForm();
            login.Show();

            // This hides the splash so the app stays alive 
            // (Closing it here might shut down the whole app)
           
        }

        private void spash_screen_Load(object sender, EventArgs e)
        {

        }
    }
}
