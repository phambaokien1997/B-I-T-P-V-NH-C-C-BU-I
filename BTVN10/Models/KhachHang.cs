using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Models
{
    public class KhachHang
    {
        // Thuộc tính của lớp KhachHang
        public int MaKhachHang { get; set; } // Thuộc tính chỉ đọc, không có setter

        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }

        // Constructor không tham số
        public KhachHang()
        {
        }

        // Constructor với tham số
        public KhachHang(int maKhachHang, string hoTen, string soDienThoai, string email, string diaChi)
        {
            MaKhachHang = maKhachHang; // Khởi tạo giá trị cho MaKhachHang trong constructor
            HoTen = hoTen;
            SoDienThoai = soDienThoai;
            Email = email;
            DiaChi = diaChi;
        }

        // Phương thức để hiển thị thông tin của khách hàng
        public override string ToString()
        {
            return $"Mã khách hàng: {MaKhachHang}, Họ và tên: {HoTen}, Số điện thoại: {SoDienThoai}, Email: {Email}, Địa chỉ: {DiaChi}";
        }
    }
}
