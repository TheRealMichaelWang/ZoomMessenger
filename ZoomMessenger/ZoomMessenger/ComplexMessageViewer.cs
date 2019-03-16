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
    public partial class ComplexMessageViewer : Form
    {
        public ComplexMessageViewer(ComplexMessage message)
        {
            InitializeComponent();
            this.Text = message.subject;
            string html = "<!DOCTYPE html><html>Subject: "+message.subject+"<hr><br>From: "+message.from + "<br>To: "+message.to + "<hr><br>"+message.body + "</html>";
            HTMLDisplay.DocumentText = html;
            this.ShowDialog();
        }
    }
}
