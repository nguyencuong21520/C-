using System;
using System.Collections.Generic;
using System.Text;

namespace buoi1
{
    public abstract class phuongTien { };
    public class oTo : phuongTien{
        public override string ToString()
        {
            return "Ô tô";
        }
    }
    public class xeMay : phuongTien
    {
        public override string ToString()
        {
            return "Xe Máy";
        }
    }
    public class xeDap : phuongTien
    {
        public override string ToString()
        {
            return "Xe Đạp";
        }
    }
    public class mayBay : phuongTien
    {
        public override string ToString()
        {
            return "Máy Bay";
        }
    }
    public class tauDien : phuongTien
    {
        public override string ToString()
        {
            return "Tàu Điện";
        }
    }
}
