using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP3_Kế_thừa_Kế_thừa_thuộc_tính_Kế_thừa_phương_thức
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NhanVien nv1 = new NhanVien();
            nv1.tenNV = "Phạm Bảo Kiên";
            nv1.maNV = 1;
            Console.WriteLine("Tên nhân viên là: {0}, mã nhân viên là: {1}",nv1.tenNV,nv1.maNV);
            NhanVienHanhChinh hc1 = new NhanVienHanhChinh();
            hc1.tenNV = "Phạm Bảo Khiêm";
            hc1.maNV = 2;
            Console.WriteLine("Tên nhân viên là: {0}, mã nhân viên là: {1}", hc1.tenNV, hc1.maNV);
            Console.WriteLine("Lương nhân viên 2 là :" + hc1.TinhLuong());
            NhanVienDiCa dc1 = new NhanVienDiCa();
            dc1.tenNV = "Đỗ Đức Uy";
            dc1.maNV = 3;
            Console.WriteLine("Tên nhân viên là: {0}, mã nhân viên là: {1}", dc1.tenNV, dc1.maNV);
            Console.WriteLine("Lương nhân viên 3 là :" + dc1.TinhLuong());
            NhanVienDiCa dc2 = new NhanVienDiCa();
            dc2.tenNV = "Phạm Ngũ Lão";
            dc2.maNV = 4;
            dc2.Ca = "Ngày";
            Console.WriteLine("Tên nhân viên là: {0}, mã nhân viên là: {1}, làm ca {2}", dc2.tenNV, dc2.maNV, dc2.Ca);

            Console.WriteLine(nv1.ThuongDuCong(25));
            Console.WriteLine(dc1.ThuongDuCong(26));
            Console.WriteLine(hc1.ThuongDuCong(27));
            Console.ReadKey();
        }
    }
}
