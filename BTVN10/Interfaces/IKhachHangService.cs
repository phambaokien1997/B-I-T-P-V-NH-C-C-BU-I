using BTVN10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Interfaces
{
    public interface IKhachHangService
    {
        // Phương thức thêm khách hàng
        void ThemKhachHang(KhachHang khachHang);

        // Phương thức xóa khách hàng
        void XoaKhachHang(int maKhachHang);

        // Phương thức sửa thông tin khách hàng
        void SuaThongTinKhachHang(int maKhachHang, KhachHang thongTinMoi);

        // Phương thức hiển thị danh sách khách hàng
        void HienThiDanhSachKhachHang();
    }
}
