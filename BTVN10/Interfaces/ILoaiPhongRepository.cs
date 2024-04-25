using BTVN10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Interfaces
{
    public interface ILoaiPhongRepository
    {
        void ThemLoaiPhong(LoaiPhong loaiPhong);
        void XoaLoaiPhong(int maLoaiPhong);
        LoaiPhong TimLoaiPhongTheoMa(int maLoaiPhong);
        void SuaThongTinLoaiPhong(int maLoaiPhong, LoaiPhong thongTinMoi);
        List<LoaiPhong> LayDanhSachLoaiPhong();
    }
}
