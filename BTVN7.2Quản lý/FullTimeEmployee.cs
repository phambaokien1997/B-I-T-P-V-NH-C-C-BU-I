using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN7._2Quản_lý
{
    public class FullTimeEmployee : Employee
    {
        public double LuongHangThang { get; }

        public FullTimeEmployee(string ten, double luongHangThang) : base(ten, "Full Time")
        {
            LuongHangThang = luongHangThang;
        }

        public override double TinhLuong()
        {
            // Lương toàn thời gian được tính theo tháng
            return LuongHangThang;
        }
    }
}
