using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {

            double m = 0;

            try
            {
                m = Convert.ToInt32(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi cú pháp");
            }
            string kq1 = "";
            string kq2 = "";
            string kq3 = "";

            // số chính phương
            for (int i = 2; i < m; i++)
            {
                if (kiemtrasocp(i))
                {

                    kq1 = kq1 + i.ToString() + ", ";
                }
                else
                { label3.Text = "Không có số chính phương"; }

            }
            label3.Text = kq1;

            //số hoàn hảo
            for (int i = 1; i < m; i++)
            {
                if (kthoanhao(i))
                    kq2 = kq2 + i.ToString() + ", ";
                else

                   label4.Text = "Không có số hoàn hảo";
            }
            label4.Text = kq2;

            //số nguyên tố
            for (int i = 1; i < m; i++)
            {
                if (kiemtrasont(i))
                {

                    kq3 = kq3 + i.ToString() + ", ";

                }
                else
                { label2.Text = "Không có số nguyên tố"; }

            }
            label2.Text = kq3;
        }

        //kiểm tra số chính phương
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

        //kiểm tra số hoàn hảo
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

        //kiểm tra số nguyên tố
        public bool kiemtrasont(int a)
        {

            // bool kq = true;
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

        private void txtn_MouseLeave(object sender, EventArgs e)
        {
            //double m;
            //m = Convert.ToInt32(txtn.Text);
            //if (m > 1000 || m < 0)
            //    this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
