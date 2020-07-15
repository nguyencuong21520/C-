using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Transactions;

namespace buoi1
{
    class canBo
    {
        protected string maCB;
        protected string hoTen;
        protected string gioiTinh;
        protected string queQuan;
        protected string ngaySinh;
        protected phuongTien phuongTiengt;
        public canBo()
        {}
        public canBo(string m, string ht, string gt, string qq, phuongTien pt)
        {
            maCB = m;
            hoTen = ht;
            gioiTinh = gt;
            queQuan = qq;
            phuongTiengt = pt;
        }
        public void xuat()
        {

            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", maCB, hoTen, gioiTinh, queQuan,ngaySinh, phuongTiengt);
        }
        public void nhap()
        {
            Console.Write("Nhập họ tên: ");
            hoTen = Convert.ToString(Console.ReadLine());
            Console.Write("Nhập mã: ");
            maCB = Convert.ToString(Console.ReadLine());
            Console.Write("Nhập giới tính: ");
            gioiTinh = Convert.ToString(Console.ReadLine());
            Console.Write("Nhập ngày sinh: ");
            ngaySinh = Convert.ToString(Console.ReadLine());
            Console.Write("Nhập quê quán: ");
            queQuan = Convert.ToString(Console.ReadLine());
            Console.WriteLine("1, xe may");
            Console.WriteLine("2, o to");
            Console.WriteLine("3, xe dap");
            Console.WriteLine("4, tau dien");
            Console.WriteLine("5, may bay");
            int xx;
            xx = Convert.ToInt32(Console.ReadLine());
            switch (xx)
            {
                case 1:
                    phuongTiengt = new xeMay();
                    break;
                case 2:
                    phuongTiengt = new oTo();
                    break;
                case 3:
                    phuongTiengt = new xeDap();
                    break;
                case 4:
                    phuongTiengt = new tauDien();
                    break;
                case 5:
                    phuongTiengt = new mayBay();
                    break;
            }

        }
    }
}
