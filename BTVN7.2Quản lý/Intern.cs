using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN7._2Quản_lý
{
    public class Intern : Employee
    {
        public double tienTra { get; set; }
        public Intern(string ten, double tientra) : base(ten, "Intern")
        {
            tienTra = tientra;
        }
        public override double TinhLuong()
        {
            return tienTra;
        }
    }
}
