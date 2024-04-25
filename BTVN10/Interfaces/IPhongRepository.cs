using BTVN10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Interfaces
{
    public interface IPhongRepository
    {
        // Thêm một phòng mới
        void ThemPhong(Phong phong);

        // Sửa thông tin của một phòng dựa trên mã phòng
        void SuaThongTinPhong(int maPhong, Phong phong);

        // Xóa một phòng dựa trên mã phòng
        void XoaPhong(int maPhong);

        // Lấy danh sách tất cả các phòng
        List<Phong> LayDanhSachPhong();

        // Tìm một phòng dựa trên mã phòng
        Phong TimPhongTheoMa(int maPhong);
    }
}
