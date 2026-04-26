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
            splash_timer.Start();
            ShowSplash();

        }

        public async void ShowSplash()
        {
            await Task.Delay(10000);
        }
        private void splash_timer_Tick(object sender, EventArgs e)
        {
            
           
        }

        private void spash_screen_Load(object sender, EventArgs e)
        {

        }
    }
}
