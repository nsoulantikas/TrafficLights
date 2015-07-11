using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TrafficLights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button3.Enabled = false;
            button4.Enabled = false;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            pictureBox1.Tag = "red";
        }

        int duration = 0;

        private void timer1_Tick(object sender, EventArgs e) //red
        {
            timer1.Enabled = false;
            timer2.Enabled = true;
            pictureBox1.Image = Properties.Resources.trl_green;
            pictureBox1.Tag = "green";  
        }
        private void timer2_Tick(object sender, EventArgs e) //green
        {
            timer2.Enabled = false;
            timer3.Enabled = true;
            pictureBox1.Image = Properties.Resources.trl_orange;
            pictureBox1.Tag = "orange";  
        }
        private void timer3_Tick(object sender, EventArgs e) // orange
        {
            timer3.Enabled = false;
            timer1.Enabled = true;
            pictureBox1.Image = Properties.Resources.trl_red;
            pictureBox1.Tag = "red";  
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            duration++;
            label5.Text = duration.ToString() + " seconds.";
        } //duration
        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Tag.ToString() == "red")
            {
                pictureBox1.Image = Properties.Resources.trl_green;
                pictureBox1.Tag = "green";
            }
            else if (pictureBox1.Tag.ToString() == "green")
            {
                pictureBox1.Image = Properties.Resources.trl_orange;
                pictureBox1.Tag = "orange";
            }
            else if (pictureBox1.Tag.ToString() == "orange")
            {
                pictureBox1.Image = Properties.Resources.trl_red;
                pictureBox1.Tag = "red";
            }
        } //Change
        private void button2_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            timer4.Enabled = true;
            int red = int.Parse(textBox1.Text) * 1000;
            int green = int.Parse(textBox3.Text) * 1000;
            int orange = int.Parse(textBox2.Text) * 1000;
            timer1.Interval = red;
            timer2.Interval = green;
            timer3.Interval = orange;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;

        } //Auto
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            duration = 0; // set duration to 0 for accurate information
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
        } //Stop
        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "0 seconds.";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;

        }

    }
}