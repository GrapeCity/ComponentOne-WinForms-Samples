using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QRCodeSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void textBox1_TextChanged(object sender, EventArgs e)
        {
            c1BarCode1.Text = textBox1.Text;
            c1QRCode1.Text = textBox1.Text;
        }

        void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            var msg = "Welcome to C1BarCode (now with Quick-Response 2D support). Notice how compact the QR code is. You can keep typing and the image slowly grows, but not by much.";
            for (int i = 1; i < msg.Length; i++)
            {
                textBox1.Text = msg.Substring(0, i);
                textBox1.Select(i, 0);
                textBox1.ScrollToCaret();
                Application.DoEvents();
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
