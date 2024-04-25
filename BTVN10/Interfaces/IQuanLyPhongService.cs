using BTVN10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Interfaces
{
    public interface IQuanLyPhongService
    {
        // Phương thức thêm phòng
        void ThemPhong(Phong phong);

        // Phương thức xóa phòng
        void XoaPhong(int maPhong);

        // Phương thức sửa thông tin phòng
        void SuaThongTinPhong(int maPhong, Phong thongTinMoi);

        // Phương thức hiển thị danh sách phòng
        void HienThiDanhSachPhong();

        // Phương thức thêm loại phòng
        void ThemLoaiPhong(LoaiPhong loaiPhong);

        // Phương thức xóa loại phòng
        void XoaLoaiPhong(int maLoaiPhong);

        // Phương thức sửa thông tin loại phòng
        void SuaThongTinLoaiPhong(int maLoaiPhong, LoaiPhong thongTinMoi);

        // Phương thức hiển thị danh sách loại phòng
        void HienThiDanhSachLoaiPhong();
    }
}
