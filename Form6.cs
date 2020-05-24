using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vatPJ
{
    public partial class Form6 : Form
    {
        public Form6(string data)
        {
            InitializeComponent();
            salary.Text = data;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int ans1 = int.Parse(n7.Text);
            int ans2 = int.Parse(n8.Text);
            
            if(ans1+ans2 >100000) //ค่าซ่อมรถ + ซ่อมบ้าน
            {
                l2.Text = "0";
            }
            else
            {
                l1.Text = ans1.ToString();
                l2.Text = ans2.ToString();
            }
            int bn1 = int.Parse(n5.Text); //เมืองหลัก เมืองรอง
            int bn2 = int.Parse(n6.Text);
            if(bn1+bn2 > 20000)
            {
                l3.Text = "0";
                l4.Text = "20000";
            }
            else
            {
                l3.Text = bn1.ToString();
                l4.Text = bn2.ToString();
            }

            int a = int.Parse(n1.Text);
            int b = int.Parse(n2.Text);
            int c = int.Parse(n3.Text);
            int d = int.Parse(n4.Text);
            int f = int.Parse(l3.Text);
            int g = int.Parse(l4.Text);
            int h = int.Parse(l1.Text);
            int i = int.Parse(l2.Text);
            int vat6;
            vat6 = a + b + c + d + f + g + h + i;
            ans6.Text = vat6.ToString();

            //รายได้สุทธิ
            int non1 = int.Parse(salary.Text);
            int income;
            income = non1 - vat6;
            outcome.Text = income.ToString();

        }

        private void vi_Click(object sender, EventArgs e)
        {
            int non1 = int.Parse(outcome.Text);
            int non2 = int.Parse(ans6.Text);
            int inout;
            inout = non1 - non2;
            int w;
            if (inout <= 150000)
            {
                w = 0;
                vatans.Text = w.ToString();
            }
            else if (inout <= 300000)
            {
                w = (inout * 5) / 100;//5%
                vatans.Text = w.ToString();
            }
            else if (inout <= 500000)
            {
                w = (inout * 10) / 100;//10%
                vatans.Text = w.ToString();
            }
            else if (inout <= 750000)
            {
                w = (inout * 15) / 100; //15%
                vatans.Text = w.ToString();
            }
            else if (inout <= 1000000)
            {
                w = (inout * 20) / 100; //20%
                vatans.Text = w.ToString();
            }
            else if (inout <= 2000000)
            {
                w = (inout * 25) / 100; //25%
                vatans.Text = w.ToString();
            }
            else if (inout <= 5000000)
            {
                w = (inout * 30) / 100;//30%
                vatans.Text = w.ToString();
            }
            else
            {
                w = (inout * 35) / 100;//35%
                vatans.Text = w.ToString();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = salary.Text;
            Form2 f2 = new Form2(data);
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string data = salary.Text;
            Form3 f3 = new Form3(data);
            f3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string data = salary.Text;
            Form4 f4 = new Form4(data);
            f4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string data = salary.Text;
            Form5 f5 = new Form5(data);
            f5.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
