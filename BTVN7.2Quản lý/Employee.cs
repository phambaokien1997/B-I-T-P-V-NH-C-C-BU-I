using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN7._2Quản_lý
{
    public abstract class Employee
    {
        public string Ten { get; set; }
        public string NhanVien { get; set; }
        protected Employee(string ten, string nhanVien)
        {     
            Ten = ten;
            NhanVien = nhanVien;
        }
        public abstract double TinhLuong();
    }
}
