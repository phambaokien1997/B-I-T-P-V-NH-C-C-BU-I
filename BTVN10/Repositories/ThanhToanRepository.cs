using BTVN10.Interfaces;
using BTVN10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Repositories
{
    public class ThanhToanRepository : IThanhToanRepository
    {
        private List<ThanhToan> danhSachThanhToan;

        public ThanhToanRepository()
        {
            danhSachThanhToan = new List<ThanhToan>();
        }

        public void ThemThanhToan(ThanhToan thanhToan)
        {
            try
            {
                danhSachThanhToan.Add(thanhToan);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm thanh toán: {ex.Message}");
                // Hoặc có thể throw lại ngoại lệ để thông báo lên tầng gọi
                throw;
            }
        }

        public void XoaThanhToan(ThanhToan thanhToan)
        {
            try
            {
                danhSachThanhToan.Remove(thanhToan);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa thanh toán: {ex.Message}");
                // Hoặc có thể throw lại ngoại lệ để thông báo lên tầng gọi
                throw;
            }
        }

        public ThanhToan TimThanhToanTheoMa(int maHoaDon)
        {
            return danhSachThanhToan.FirstOrDefault(t => t.MaHoaDon == maHoaDon);
        }

        public List<ThanhToan> LayDanhSachThanhToan()
        {
            return danhSachThanhToan;
        }
    }
}
