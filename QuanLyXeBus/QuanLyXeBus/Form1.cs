using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeBus
{
    public partial class Form1 : Form
    {
        BusEntities Datane = new BusEntities();
        
        public Form1()
        {
            InitializeComponent();
        }
        Button currentBtn;
        int tuoi;
        string hoTen;
        int giaVe = 50000;
        string i;
        void loadData()
        {
            dataGridView1.DataSource = Datane.khacHangs.ToList();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            

        }

        private void button47_Click(object sender, EventArgs e)
        {
            //if(numericUpDown1.Value >= 50)
            //{
            //    textBox3.Text = Convert.ToString(250000);
            //}else if(numericUpDown1.Value < 18)
            //{
            //    textBox3.Text = Convert.ToString(40000);
            //}
            //else
            //{
            //    textBox3.Text = Convert.ToString(50000);
            //}
            khacHang Ct = new khacHang()
            {
                vitringoi = Convert.ToString(i),
                TenKhach = Convert.ToString(textBox1.Text),
                Tuoi = int.Parse(numericUpDown1.Value.ToString()),
                GiaBan = int.Parse(textBox2.Text)
            };
            currentBtn.BackColor = Color.Red;
            Datane.khacHangs.Add(Ct);
            Datane.SaveChanges();




        }

        private void button48_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            //foreach(var i in tabPage1.Controls)
            //{
            //    if(i is Button)
            //    {
            //        var button = i as Button;
            //        if (button.Text == "Thanh Toán" || button.Text == "Lái Xe") continue;
            //        if(int.Parse(button.Text) == ghe)
            //        {

            //        }
            //    }
            //}
        }
        
        protected void Button_Click(Object sender, EventArgs e)
        {
            if (currentBtn != null)
            {
               // if (currentBtn.Enabled == true)
                 //   currentBtn.BackColor = Color.Transparent;
            }
            currentBtn = sender as Button;
            currentBtn.BackColor = Color.Coral;
            //i = int.Parse(currentBtn.Text);
            i = currentBtn.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tuoi = int.Parse(numericUpDown1.Value.ToString());
            if (tuoi > 49)
            {
                textBox2.Text = (50000 * (0.5)).ToString();
                giaVe = int.Parse(textBox2.Text);
            }
            else if (tuoi < 18)
            {
                textBox2.Text = (50000 * (0.8)).ToString();
                giaVe = int.Parse(textBox2.Text);
            }
            else
                textBox2.Text = Convert.ToString(50000);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           var Hanh =  Datane.khacHangs.Select(i => i.vitringoi).ToList();
            foreach(Control i in tabPage1.Controls)
            {
                if(i is Button)
                {
                    foreach(var j in Hanh)
                    {
                        if(j.ToString() == i.Text)
                        {
                            i.BackColor = Color.Red;
                        }
                    }
                }
            }
            foreach (Control control in tabPage1.Controls)
            {
                if (control.Name.StartsWith("button"))
                {
                    control.Click += new EventHandler(Button_Click);
                }
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            string sv1 = txtmasv.Text;
            sinhvien sv = dssv.sinhviens.Where(p => p.MaSV == sv1).SingleOrDefault();
            dssv.sinhviens.Remove(sv);
            dssv.SaveChanges();
        }
    }
}
