using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZoomMessenger
{
    public partial class Prompt : Form
    {
        public string output = "";

        public Prompt(string title,string defaultinput)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Text = title;
            this.Input.Text = defaultinput;
            this.ShowDialog();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            output = Input.Text;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                output = Input.Text;
                this.Close();
            }
        }
    }
}
