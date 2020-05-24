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
    public partial class Form2 : Form
    {
        public Form2(string data)
        {
            InitializeComponent();
            textBox1.Text = data;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            Form3 f3 = new Form3(data);
            f3.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            Form4 f4 = new Form4(data);
            f4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            Form5 f5 = new Form5(data);
            f5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            Form6 f6 = new Form6(data);
            f6.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (nchild.Checked)
            {
                childans.Enabled = false;
                child60.Enabled = false;
                child61.Enabled = false;

            }
            else
            {
                childans.Enabled = true;
                child60.Enabled = true;
                child61.Enabled = true;
            }
               
        }

        private void button7_Click(object sender, EventArgs e)//กลุ่มที่หนึ่ง ลดหย่อนเกี่ยวกับตัวเองและครอบครัว
        {
            if (p1.Checked) //คู่สมรสที่ไม่มีรายได้
            {
                int m1 = int.Parse(n1.Text);
    
                if(m1 <= 60000)
                {
                    v1.Text = m1.ToString();
                }
                else
                {
                    v1.Text = "60000";
                }
            }
            if (p2.Checked) //ค่าฝากครรภ์และค่าคลอดบุตร
            {
                int m2 = int.Parse(n2.Text);

                if (m2 <= 60000)
                {
                    v2.Text = m2.ToString();
                }
                else
                {
                    v2.Text = "60000";
                }
            }
            int pr = int.Parse(parent.Text); //พ่อแม่
            int ans;
            ans = pr * 30000;
            pans.Text = ans.ToString();

            if (child.Checked) //ลูก
            {
                int c60 = int.Parse(child60.Text);
                int c61 = int.Parse(child61.Text);
                int cans;
                if (c60 < 1)
                {
                    
                    if (c61 + c60 <= 1)
                    {
                        cans = c61 * 30000;
                    }
                    else
                    {
                        cans = (c61 - 1) * 60000 + 30000;
                    }
                

                }
                else
                {
                    
                    cans =( c60 * 30000)+(c61*60000);
                    
                   
                } 
                 childans.Text = cans.ToString();
                 label7.Text = cans.ToString();


            }

            int dsb = int.Parse(sos.Text); //ผู้พิการ
            int adsb;
            adsb = dsb * 60000;
            disabled.Text = adsb.ToString();

            int a = int.Parse(textBox2.Text);
            int b = int.Parse(v1.Text);
            int c = int.Parse(v2.Text);
            int d = int.Parse(pans.Text);
            int f = int.Parse(label7.Text);
            int g = int.Parse(disabled.Text);
            int tax;
            tax = a + b + c + d + f + g;
            anstax.Text = tax.ToString();

            //รายได้สุทธิ
            int non1 = int.Parse(textBox1.Text);
            int income;
            income = non1 - tax;
            outcome.Text = income.ToString();




        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void vi_Click(object sender, EventArgs e)
        {
            int non1 = int.Parse(textBox1.Text);
            int non2 = int.Parse(anstax.Text);
            int inout;
            inout = non1 - non2 ;
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

        private void button9_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            Form3 f3 = new Form3(data);
            f3.Show();
            this.Hide();
        }
    }
}
