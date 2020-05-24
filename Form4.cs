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
    public partial class Form4 : Form
    {
        public Form4(string data)
        {
            InitializeComponent();
            salary.Text = data;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int home = int.Parse(n1.Text);
            
            if(home <= 100000) //ดอกเบี้ยบ้าน
            {
                l1.Text = home.ToString();
            }
            else
            {
                l1.Text = "100000";
            }
            

            if (radioButton1.Checked) //โครงการบ้านหลังแรก ปี พ.ศ. 2558
            {
                int h58 = int.Parse(home58.Text);
               
                if(h58 <= 300000)
                {
                    h58 = ((h58 * 20) / 100);
                }
                else
                {
                    h58 = ((300000 * 20) / 100);
                }
                l2.Text = h58.ToString();
            }

            if (radioButton2.Checked) //ซื้อบ้านหลังแรกในปี พ.ศ. 2562
            {
                int h62 = int.Parse(home62.Text);
                if(h62 <= 200000)
                {
                    l3.Text = h62.ToString();
                }
                else if(h62>5000000)
                {
                    h62 = 0;
                }
                l3.Text = h62.ToString();
                
            }

            int a = int.Parse(l1.Text);
            int b = int.Parse(l2.Text);
            int c = int.Parse(l3.Text);
            int vat;
            vat = a + b + c;
            answer.Text = vat.ToString();

            //รายได้สุทธิ
            int non1 = int.Parse(salary.Text);
            int income;
            income = non1 - vat;
            outcome.Text = income.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
              
                home62.Enabled = false;
            }
            else
            {
               
                home62.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
               
                home58.Enabled = false;
            }
            else
            {
               
                home58.Enabled = true;
            }
        }

        private void vi_Click(object sender, EventArgs e)
        {
            int non1 = int.Parse(outcome.Text);
            int non2 = int.Parse(answer.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string data = salary.Text;
            Form6 f6 = new Form6(data);
            f6.Show();
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

            string data = salary.Text;
            Form5 f5 = new Form5(data);
            f5.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string data = salary.Text;
            Form3 f3 = new Form3(data);
            f3.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string data = salary.Text;
            Form2 f2 = new Form2(data);
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            string data = salary.Text;
            Form5 f5 = new Form5(data);
            f5.Show();
            this.Hide();
        }
    }
}
