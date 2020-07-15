using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timSo
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            try
            {
                n = Convert.ToInt32(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập số đi bạn ơi");
            }

            string kq1 = "",kq2="",kq3="";
            label2.Text = string.Format("Các số nguyên tố nhỏ hơn {0}", n);
            label3.Text = string.Format("Các số chính phương nhỏ hơn {0}", n);
            label4.Text = string.Format("Các số hoàn chỉnh nhỏ hơn {0}", n);
            for (int i =  1; i < n; i++)
            {
                if (kiemtrasont(i))
                {
                    kq3 = kq3 + i.ToString() + "    ";
                }
                else
                {
                    richTextBox1.Text = "Không có nguyên tố";
                }
                richTextBox1.Text = kq3;
            }

            for(int i=2; i < n; i++)
            {
                if (kiemtrasocp(i))
                {
                    kq1 = kq1 + i.ToString() + "    ";
                }
                else
                {
                    richTextBox2.Text = "Không có số chính phương";
                }
                richTextBox2.Text = kq1;
            }
            for (int i = 1; i < n; i++)
            {

                if (kthoanhao(i))
                {
                    kq2 = kq2 + i.ToString() + "    ";
                }
                else
                {
                    richTextBox3.Text = "không có số hoàn hảo";
                }
                richTextBox3.Text = kq2;
            }


        }
        public bool kiemtrasocp(int a)
        {

            bool kq = false;

            double x = Math.Sqrt(a);

            if ((int)x * x == a)
            {
                kq = true;
            }

            return kq;

        }
        public bool kthoanhao(int n)
        {
            bool kq = false;
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                kq = true;
            }
            return kq;
        }
        public bool kiemtrasont(int a)
        {

            double x = Math.Sqrt(a);
            if (a <= 1)
                return false;
            for (int i = 2; i <= x; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
