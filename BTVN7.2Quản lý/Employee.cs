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
        public string NhanVien { get; }

        protected Employee(string ten, string nhanVien)
        {
            Ten = ten;
            NhanVien = nhanVien;
        }

        // Phương thức tính toán lương tương ứng cho mỗi loại nhân viên
        public abstract double TinhLuong();
    }
}
