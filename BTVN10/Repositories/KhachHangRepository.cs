using BTVN10.Interfaces;
using BTVN10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Repositories
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private List<KhachHang> danhSachKhachHang;

        public KhachHangRepository()
        {
            // Khởi tạo danh sách khách hàng
            danhSachKhachHang = new List<KhachHang>();
        }

        // Thêm khách hàng mới vào danh sách
        public void ThemKhachHang(KhachHang khachHang)
        {
            try
            {
                danhSachKhachHang.Add(khachHang);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm khách hàng: {ex.Message}");
                // Hoặc có thể throw lại ngoại lệ để thông báo lên tầng gọi
                throw;
            }
        }

        // Xóa thông tin khách hàng khỏi danh sách
        public void XoaKhachHang(KhachHang khachHang)
        {
            try
            {
                danhSachKhachHang.Remove(khachHang);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa khách hàng: {ex.Message}");
                // Hoặc có thể throw lại ngoại lệ để thông báo lên tầng gọi
                throw;
            }
        }

        // Sửa thông tin khách hàng trong danh sách
        public void SuaThongTinKhachHang(KhachHang khachHang)
        {
            try
            {
                // Tìm khách hàng trong danh sách và cập nhật thông tin
                KhachHang khachHangCanSua = danhSachKhachHang.Find(kh => kh.MaKhachHang == khachHang.MaKhachHang);
                if (khachHangCanSua != null)
                {
                    khachHangCanSua.HoTen = khachHang.HoTen;
                    khachHangCanSua.SoDienThoai = khachHang.SoDienThoai;
                    khachHangCanSua.DiaChi = khachHang.DiaChi;
                    khachHangCanSua.Email = khachHang.Email;
                }
                else
                {
                    Console.WriteLine($"Không tìm thấy khách hàng mã {khachHang.MaKhachHang}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi sửa thông tin khách hàng: {ex.Message}");
                // Hoặc có thể throw lại ngoại lệ để thông báo lên tầng gọi
                throw;
            }
        }

        // Tìm khách hàng trong danh sách theo mã
        public KhachHang TimKhachHangTheoMa(int maKhachHang)
        {
            return danhSachKhachHang.FirstOrDefault(kh => kh.MaKhachHang == maKhachHang);
        }

        // Lấy danh sách khách hàng
        public List<KhachHang> LayDanhSachKhachHang()
        {
            return danhSachKhachHang;
        }
    }
}
