using BTVN10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Interfaces
{
    public interface IThanhToanService
    {
        ThanhToan TinhTongTienThue(Phong phong, DateTime ngayDat, DateTime ngayTra, int maDatPhong, int maKhachHang, int maPhong);
    }
}
