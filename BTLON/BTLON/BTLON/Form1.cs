using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON
{
    public partial class Form1 : Form
    {
        int t1 = 0, t2 = 0, t3 = 0, t4 = 0, t5 = 0, t6 = 0, t7 = 0, t8 = 0;
        public Form1()
        {
            InitializeComponent();
           
            
        }

        void ttTien()
        {
            //  dataGridView1.Columns[4];

            int a = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                {
                    a += Convert.ToInt32(r.Cells[4].Value);
                }
            }
            textBox3.Text = Convert.ToString(a);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button36_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            int t = Convert.ToInt32(numericUpDown2.Value.ToString());
            
            if (t != 0)
            {
                t2 += 1;
                dataGridView1.Rows.Add("Da2","Hướng Dương", t, "100", t * 100);
                ttTien();
            }
            else
            {
                MessageBox.Show("Chưa chọn số lượng");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows.Remove = ;
        }

        private void button62_Click(object sender, EventArgs e)
        {

                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(numericUpDown3.Value.ToString());
            
            if (t != 0)
            {
                t3 += 1;
                dataGridView1.Rows.Add("Da3","Bò Khô", t, "300", t * 300);
                ttTien();
            }
            else
            {
                MessageBox.Show("Chưa chọn số lượng");
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(numericUpDown4.Value.ToString());
            
            if (t != 0)
            {
                t4 += 1;
                dataGridView1.Rows.Add("Da4","Xúc Xích", t, "400", t * 400);
                ttTien();
            }
            else
            {
                MessageBox.Show("Chưa chọn số lượng");
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(numericUpDown5.Value.ToString());
            
            if (t != 0)
            {
                t5 += 1;
                dataGridView1.Rows.Add("Da5", "Khoai Chiên", t, "300", t * 300);
                ttTien();

            }
            else
            {
                MessageBox.Show("Chưa chọn số lượng");
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(numericUpDown6.Value.ToString());
            if (t != 0)
            {
                t6 += 1;
                dataGridView1.Rows.Add("Da6", "Nem Chua Rán", t, "350", t * 350);
                ttTien();
            }
            else
            {
                MessageBox.Show("Chưa chọn số lượng");

            }

            
        }

        private void button41_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(numericUpDown7.Value.ToString());
            if (t != 0)
            {
                t7 += 1;
                dataGridView1.Rows.Add("Da7", "Gà Pop", t, "400", t * 400);
                ttTien();
            }
            else
            {
                MessageBox.Show("Chưa chọn số lượng");
                
            }
            
        }

        private void button42_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(numericUpDown8.Value.ToString());
            if(t != 0)
            {
                t8 += 1;
                dataGridView1.Rows.Add("Da8", "Chân Gà", t, "300", t * 300);
                ttTien();



            }
            else
            {
                MessageBox.Show("Chưa chọn số lượng");
            }
            
        }

        private void dataGridView1_DockChanged(object sender, EventArgs e)
        {
            textBox3.Text = "aaa";
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void button53_Click(object sender, EventArgs e)
        {
            

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            
            int t = Convert.ToInt32(numericUpDown1.Value.ToString());
            if (t != 0)
            {
                t1 += 1;
                dataGridView1.Rows.Add("Da1", "Viên Chiên", t, "200", t * 200);
                ttTien();

            }
            else
            {
                MessageBox.Show("Chưa chọn số lượng");
            }
            
        }
    }
}
