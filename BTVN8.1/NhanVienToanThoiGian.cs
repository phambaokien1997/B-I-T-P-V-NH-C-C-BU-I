using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN8._1
{
    class NhanVienToanThoiGian : NhanVien
    {
        public double LuongThang {  get; set; }
        public NhanVienToanThoiGian(string ten, double luongThang) : base(ten)
        {
            LuongThang = luongThang;
        }
        public override void xuatNV()
        {
            base.xuatNV();
            Console.WriteLine("Lương tháng : " + LuongThang );
        }
    }
}
