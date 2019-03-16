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
    public partial class ComplexMessageComposer : Form
    {
        public bool canceled = true;
        public ComplexMessage output;

        public ComplexMessageComposer(string name)
        {
            InitializeComponent();
            FromInput.Text = name;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ShowDialog();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Subject.Text))
            {
                Subject.Text = "No Subject";
            }
            if(string.IsNullOrEmpty(Body.Text))
            {
                MessageBox.Show("The message body is empty. That isn't allowed","Zoom Messenger",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            output = new ComplexMessage(FromInput.Text, ToInput.Text, Subject.Text, Body.Text);
            canceled = false;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
