using BTVN10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Interfaces
{
    public interface IKhachHangRepository
    {
        void ThemKhachHang(KhachHang khachHang);
        void XoaKhachHang(KhachHang khachHang);
        void SuaThongTinKhachHang(KhachHang khachHang);
        KhachHang TimKhachHangTheoMa(int maKhachHang);
        List<KhachHang> LayDanhSachKhachHang();
    }
}
