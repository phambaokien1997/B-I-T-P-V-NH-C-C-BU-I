using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Interfaces
{
    public interface IDatPhongService
    {
        // Phương thức đặt phòng
        void DatPhong(int maPhong, int maKhachHang, DateTime ngayDat, DateTime ngayNhan, DateTime ngayTra);

        // Phương thức hủy đặt phòng
        void HuyDatPhong(int maPhong, DateTime ngayNhan, DateTime ngayTra);
    }
}
