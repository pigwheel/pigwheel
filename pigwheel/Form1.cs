using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pigwheel
{

    public partial class Form1 : Form
    {
        int i, i2, i3, i4, i5;
        string k1, k2, k3, k4;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string kk)
        {
            k4 = kk;


            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            k1 = i2.ToString();
            k2 = i3.ToString();
            k3 = i4.ToString();
            if (timer1.Interval == 10)
            {
                i = i + 1;
                label4.Text = i.ToString();
            }
            if (i == 100)
            {
                i2 = i2 + 1;
                i = 0;
                label3.Text = i2.ToString();
            }
            if (i2 == 59)
            {
                i3 = i3 + 1;
                i2 = 0;
                label2.Text = i3.ToString();
            }
            if (i3 == 59)
            {
                i4 = i4 + 1;
                i3 = 0;
                label1.Text = i4.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = false;
            if (button1.Text == "จับเวลา")
            {
                button1.Text = "เก็บ";
                timer1.Enabled = true;
            }
            else if (button1.Text == "เก็บ")
            {
                i5 = i5 + 1;
                listBox1.Items.Add(k4 + "   " + i5 + "   " + k3 + ":" + k2 + ":" + k1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "เปลี่ยนคำนำหน้า")
            {
                textBox1.Text = "";
                button1.Enabled = false;
                button2.Text = "ตกลง";
                textBox1.Visible = true;
                textBox1.TabStop = true;
            }
            else
            {
                button1.Enabled = true;
                button2.Text = "เปลี่ยนคำนำหน้า";
                textBox1.Visible = false;
                textBox1.TabStop = false;
                k4 = textBox1.Text;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Text = "จับเวลา";
            timer1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            i = 0;
            i2 = 0;
            i3 = 0;
            i4 = 0;
            i5 = 0;
            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";
            label4.Text = "00";
            listBox1.Items.Clear();
        }
    }
}