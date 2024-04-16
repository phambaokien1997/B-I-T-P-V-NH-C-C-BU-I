using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN8._1
{
    class NhanVienBanThoiGian : NhanVien
    {
        public double luong1Gio { get; set; }
        public double gioDaLam { get; set; }
        public NhanVienBanThoiGian(string ten, double luong1gio, double giodaLam) : base(ten)
        {
            luong1Gio= luong1gio;
            gioDaLam= giodaLam;
        }
        public override void xuatNV()
        {
            base.xuatNV();
            Console.WriteLine($"Lương 1 giờ: {luong1Gio}, Số giờ làm việc: {gioDaLam}, tiền lương tổng : {luong1Gio*gioDaLam}");
        }
    }
}
