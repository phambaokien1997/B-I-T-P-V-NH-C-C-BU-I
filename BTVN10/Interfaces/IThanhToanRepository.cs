using BTVN10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Interfaces
{
    public interface IThanhToanRepository
    {
        void ThemThanhToan(ThanhToan thanhToan);
        void XoaThanhToan(ThanhToan thanhToan);
        ThanhToan TimThanhToanTheoMa(int maHoaDon);
        List<ThanhToan> LayDanhSachThanhToan();
    }
}
