using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace com.codeBlack.winLock
{
    public partial class encryptionKeyInputForm : Form
    {
        public string encryption_key;
        public encryptionKeyInputForm()
        {
            InitializeComponent();
        }

        private void encryptionKeyField_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            encryption_key = encryptionKeyField.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void encryptionKeyInputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
