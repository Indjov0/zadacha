using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerrrr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Hide();
            linkLabel2.Text = "Kamera";
            linkLabel2.Links.Add(0, linkLabel2.Text.Length, "https://webcamsbg.com/sofia-pirotska-live-webcam-vremeto-online-kamera.html");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pictureBox1.Show();
            pictureBox1.Enabled = true;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox1.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Enabled = true;
            webBrowser1.Navigate("https://weather-webcam.eu/ueb-kamera-ot-sofiya-lyulin-7-sledete-vremeto-i-trafika/");
            WebBrowser webbrouser2 = new WebBrowser();
            webbrouser2.Location = pictureBox2.Location;
            webbrouser2.Size = pictureBox2.Size;
            webbrouser2.Navigate("https://webcamsbg.com/sofia-pirotska-live-webcam-vremeto-online-kamera.html");
            this.Controls.Add(webbrouser2);
            pictureBox2.Visible = false;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://weather-webcam.eu/ueb-kamera-ot-sofiya-linkLabel2");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://webcamsbg.com/sofia-pirotska-live-webcam-vremeto-online-kamera.html");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(url))
            {
                Process.Start(url);

            }
        }
    }
}
