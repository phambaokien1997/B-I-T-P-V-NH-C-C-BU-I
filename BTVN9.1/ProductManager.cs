using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN9._1
{
    public abstract class ProductManager : Product
    {
        public abstract void NhapSanPham();
        public abstract void GiaSauKhiTinhToanXong();
        public abstract void DSHienThiTheoChietKhau(Loaichietkhau loaiChietKhau);
        public abstract void DSHienThiTheoChietKhauGiamDan();
        public abstract void DSHienThiTheoTenSanPham(string ten);
    }
}
