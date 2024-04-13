using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN7._2Quản_lý
{
    public class PartTimeEmployee :Employee
    {
        public double Tien1Gio { get; }
        public double SoGioDaLam { get; }

        public PartTimeEmployee(string ten, double tien1Gio, double soGioDaLam) : base(ten, "Part Time")
        {
            Tien1Gio = tien1Gio;
            SoGioDaLam = soGioDaLam;
        }

        public override double TinhLuong()
        {
            // Lương bán thời gian được tính theo số giờ làm việc
            return Tien1Gio * SoGioDaLam;
        }
    }
}
