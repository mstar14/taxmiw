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
    public partial class Form5 : Form
    {
        public Form5(string data)
        {
            InitializeComponent();
            salary.Text = data;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(school.Text); //สนับสนุนการศึกษา
            s1 = s1 * 2;
            l1.Text = s1.ToString();

            int s2 = int.Parse(hospital.Text); //สถานพยาบาลของรัฐ 
            s2 = s2 * 2;
            l2.Text = s2.ToString();

            int s3 = int.Parse(sport.Text); //สนับสนุนการกีฬา
            s3 = s3 * 2;
            l3.Text = s3.ToString();

            int s4 = int.Parse(pub.Text); //บริจาคเพื่อสาธารณประโยชน์ต่างๆ
            s4 = s4 * 2;
            l4.Text = s4.ToString();

            int s5 = int.Parse(storm.Text); //ช่วยเหลืออุทกภัยน้ำท่วมจากพายุปาบึก
            l5.Text = s5.ToString();

            int s6 = int.Parse(gen.Text); //บริจาคทั่วไป
            l6.Text = s6.ToString();

            int s7 = int.Parse(pha.Text); //บริจาคให้พรรคการเมือ
            l7.Text = s7.ToString();


            int a = int.Parse(l1.Text);
            int b = int.Parse(l2.Text);
            int c = int.Parse(l3.Text);
            int d = int.Parse(l4.Text);
            int f = int.Parse(l5.Text);
            int g = int.Parse(l6.Text);
            int h = int.Parse(l7.Text);
            
            int vat5;
            vat5 = a + b + c + d + f + g + h ;
            

            int slr = int.Parse(salary.Text);
            int taxans = int.Parse(taxen.Text);
            int namt,ansna,ansnamt;
            namt = slr - taxans; //รายได้ต่อปี - ค่าลดหย่อนภาษีอื่นๆ
            ansna = namt - ((namt * 10) / 100); //หา 10 %
            ansnamt = ansna - taxans;
            ans5.Text = ansnamt.ToString();

            if (ansnamt < vat5)
            {
                ans61.Text = ansnamt.ToString();
            }
            else
            {
                ans61.Text = vat5.ToString();
            }




            //รายได้สุทธิ
            int q1 = int.Parse(ans61.Text); //รายได้พึงประเมิน
            int q2 = int.Parse(ans5.Text); //ค่าลดหย่อน
            int qout;
             qout = q2 - q1;
           outcome.Text = qout.ToString();

           
        }

        private void vi_Click(object sender, EventArgs e)
        {
            int non1 = int.Parse(outcome.Text);
            int non2 = int.Parse(ans61.Text);
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

        private void label7_Click(object sender, EventArgs e)
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
            Form6 f6 = new Form6(data);
            f6.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}