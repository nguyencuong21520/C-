using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace dataSinhVien
{
    public partial class Form1 : Form
    {

        ThongtinsinhvienContext alo = new ThongtinsinhvienContext();
        public Form1()
        {
           
            InitializeComponent();
        }
        void loaddata()
        {
            //var result = huhu.ThongTin.ToList();
            abc1.DataSource = alo.ThongTin.ToList();        
        }
        void addData()
        {
            string gioiTinh="";
            if(radioButton1.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else if(radioButton2.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            ThongTin inf = new ThongTin()
            {
                MaSv = textBox1.Text,
                HoTen = textBox2.Text,
                NgaySinh = dateTimePicker1.Value,
                GioiTinh = gioiTinh,
                QuenQuan = comboBox1.Text,
                Lop = comboBox2.Text,
                Khoa = comboBox3.Text,
            };
            alo.ThongTin.Add(inf);
            alo.SaveChanges();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
