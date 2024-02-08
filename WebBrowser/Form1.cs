using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");
            
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
                    if(e.KeyCode==Keys.Enter)
                webBrowser1.Navigate(comboBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void groupBox1_Layout(object sender, LayoutEventArgs e)
        {
            comboBox1.Width = groupBox1.Width - 130;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("google.com");
        }
    }

    
    }

