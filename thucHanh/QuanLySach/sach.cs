//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySach
{
    using System;
    using System.Collections.Generic;
    
    public partial class sach
    {
        public string masach { get; set; }
        public string tenlnxb { get; set; }
        public Nullable<int> soluong { get; set; }
        public Nullable<int> Dongia { get; set; }
        public string maloai { get; set; }
        public string manhaxuatban { get; set; }
        public string matacgia { get; set; }
    
        public virtual loaisach loaisach { get; set; }
        public virtual NXB NXB { get; set; }
        public virtual Tacgia Tacgia { get; set; }
    }
}
