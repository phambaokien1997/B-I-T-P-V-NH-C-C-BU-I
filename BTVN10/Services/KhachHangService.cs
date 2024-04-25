using BTVN10.Interfaces;
using BTVN10.Models;
using BTVN10.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Services
{
    public class KhachHangService : IKhachHangService
    {
        private KhachHangRepository khachHangRepository;

        public KhachHangService(KhachHangRepository khachHangRepo)
        {
            khachHangRepository = khachHangRepo;
        }

        public void ThemKhachHang(KhachHang khachHang)
        {
            try
            {
                khachHangRepository.ThemKhachHang(khachHang);
                Console.WriteLine("Thêm khách hàng thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm khách hàng: {ex.Message}");
            }
        }

        public void XoaKhachHang(int maKhachHang)
        {
            try
            {
                KhachHang khachHang = khachHangRepository.TimKhachHangTheoMa(maKhachHang);
                if (khachHang != null)
                {
                    khachHangRepository.XoaKhachHang(khachHang);
                    Console.WriteLine("Xóa khách hàng thành công.");
                }
                else
                {
                    Console.WriteLine("Không tìm thấy khách hàng cần xóa.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa khách hàng: {ex.Message}");
            }
        }

        public void SuaThongTinKhachHang(int maKhachHang, KhachHang thongTinMoi)
        {
            try
            {
                KhachHang khachHang = khachHangRepository.TimKhachHangTheoMa(maKhachHang);
                if (khachHang != null)
                {
                    khachHangRepository.SuaThongTinKhachHang(thongTinMoi);
                    Console.WriteLine("Sửa thông tin khách hàng thành công.");
                }
                else
                {
                    Console.WriteLine("Không tìm thấy khách hàng cần sửa thông tin.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi sửa thông tin khách hàng: {ex.Message}");
            }
        }

        public void HienThiDanhSachKhachHang()
        {
            try
            {
                List<KhachHang> danhSachKhachHang = khachHangRepository.LayDanhSachKhachHang();
                if (danhSachKhachHang.Count == 0)
                {
                    Console.WriteLine("Danh sách khách hàng trống.");
                    return;
                }

                Console.WriteLine("Danh sách khách hàng:");
                foreach (var khachHang in danhSachKhachHang)
                {
                    Console.WriteLine(khachHang.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi hiển thị danh sách khách hàng: {ex.Message}");
            }
        }
    }
}
