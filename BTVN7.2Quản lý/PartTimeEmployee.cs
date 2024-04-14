using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN7._2Quản_lý
{
    public class PartTimeEmployee :Employee
    {
        public double Tien1Gio { get; set; }
        public double SoGioDaLam { get; set; }
        public PartTimeEmployee(string ten, double tien1Gio, double soGioDaLam) : base(ten, "Part Time")
        {
            Tien1Gio = tien1Gio;
            SoGioDaLam = soGioDaLam;
        }
        public override double TinhLuong()
        {
            return Tien1Gio * SoGioDaLam;
        }
    }
}
