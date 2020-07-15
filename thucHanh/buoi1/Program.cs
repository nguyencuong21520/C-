using System;
using System.Collections.Generic;
using System.Text;

namespace buoi1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
           /* Console.WriteLine("Hello World!");
            phuongTien ha;
            ha = new xeMay();
            Console.WriteLine(ha);
            Console.ReadLine();*/

            int a;
            // int n = Convert.ToInt32(Console.ReadLine());
            List<canBo> abc = new List<canBo>();
            
            do
            {
                Console.WriteLine("--------Nhap lua chon them thong tin--------");
                Console.WriteLine("-----nhap '1': them thong tin can bo");
                Console.WriteLine("-----nhap '2': xuat thong tin can bo");
                Console.WriteLine("-----nhap '0': thoat khoi chuong trinh");
                Console.WriteLine("\n");
                Console.Write("nhap lua chon cua ban: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Nhap thong tin Can bo: ");
                        canBo cbo = new canBo();
                        cbo.nhap();
                        abc.Add(cbo);
                        
                        break;
                    case 2:
                        Console.WriteLine("MaCB\tHo ten\tGioitinh\tQue Quan\tHinh thuc di chuyen");
                        foreach (var i in abc)
                        i.xuat();
                        break;
                }
                Console.WriteLine("\t");
            } while (a != 0);
        }
    }
}
