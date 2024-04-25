using BTVN10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Interfaces
{
    public interface IDatPhongRepository
    {
        void ThemDatPhong(DatPhong datPhong);
        void XoaDatPhong(int maDatPhong);
        List<DatPhong> LayDanhSachDatPhong();
        DatPhong TimDatPhongTheoPhongVaThoiGian(int maPhong, DateTime ngayNhan, DateTime ngayTra);
        bool KiemTraPhongTrongThoiGian(int maPhong, DateTime ngayNhan, DateTime ngayTra);
    }
}
