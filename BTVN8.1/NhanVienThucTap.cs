using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN8._1
{
    class NhanVienThucTap : NhanVien
    {
        public double tienTroCap {  get; set; }
        public NhanVienThucTap(string ten, double tientrocap) : base(ten)
        {
            tienTroCap = tientrocap;
        }
        public override void xuatNV()
        {
            base.xuatNV();
            Console.WriteLine("Tiền trợ cấp: " + tienTroCap);
        }
    }
}
