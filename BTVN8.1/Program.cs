using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            NhanVienToanThoiGian NVTTG = new NhanVienToanThoiGian("Phạm Bảo Kiên", 3000000);
            NVTTG.xuatNV();
            NhanVienBanThoiGian NVBTG = new NhanVienBanThoiGian("Phạm Bảo Khiêm", 16000, 1000);
            NVBTG.xuatNV();
            NhanVienThucTap NVTT = new NhanVienThucTap("Đỗ Đức Uy", 500000);
            NVTT.xuatNV();
            Console.ReadKey();
        }
    }
}
