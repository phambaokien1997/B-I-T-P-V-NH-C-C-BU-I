using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BTVN9._1
{
    public class ConcreteProductManager : ProductManager
    {
        private List<Product> sanphams = new List<Product>();
        public override void NhapSanPham()
        {
            Console.Write("Tên Sản Phẩm: ");
            string ten = Console.ReadLine();
            if (!ProductValidator.ValidateProductName(ten))
            {
                return; // Thoát khỏi phương thức nếu tên sản phẩm không hợp lệ
            }
            Console.Write("Nhập Giá Sản Phẩm");
            double gia = Convert.ToDouble(Console.ReadLine());
            if (!ProductValidator.ValidateProductPrice(gia))
            {
                return; // Thoát khỏi phương thức nếu giá sản phẩm không hợp lệ
            }
            Console.WriteLine("Chọn loại chiết khấu (0. Theo tiền:  , 1. Theo phần trăm:");
            int giaTriChon = Convert.ToInt32(Console.ReadLine());
            while (!int.TryParse(Console.ReadLine(), out giaTriChon) || giaTriChon < 0 || giaTriChon > 1)
            {
                Console.WriteLine("Làm ơn chọn 0 hoặc 1.");
                Console.WriteLine("Chọn loại chiết khấu (0. Theo tiền:  , 1. Theo phần trăm:");
            }
            Loaichietkhau loaiChietKhau = (Loaichietkhau)giaTriChon;
            double giaTriChietKhau = 0;
            if (loaiChietKhau == Loaichietkhau.TheoSoTien || loaiChietKhau == Loaichietkhau.TheoPhanTram)
            {
                Console.WriteLine("Nhập giá trị chiết khấu vào đây: ");
                giaTriChietKhau = Convert.ToDouble(Console.ReadLine());
                while (!double.TryParse(Console.ReadLine(), out giaTriChietKhau))
                {
                    Console.WriteLine("Nhập đúng giùm cái!!!");
                    Console.WriteLine("Nhập giá trị chiết khấu vào đây: ");
                }
                if (!ProductValidator.ValidateDiscountType(loaiChietKhau, giaTriChietKhau))
                {
                    return; // thoát khỏi chương trình nếu không hợp lệ
                }
            }
            sanphams.Add(new Product { Ten = ten, Gia = gia, Loaichietkhau = loaiChietKhau, GiaTriChietKhau = giaTriChietKhau });
        }
        public override void GiaSauKhiTinhToanXong()
        {
            foreach (var sanpham in sanphams)
            {
                double chietKhau = sanpham.TinhChietKhau();
                sanpham.GiaSauKhiChietKhau = sanpham.Gia - chietKhau;
            }
        }
        public override void DSHienThiTheoChietKhau(Loaichietkhau loaiChietKhau)
        {
            foreach (var sanpham in sanphams)
            {
                if (sanpham.Loaichietkhau == loaiChietKhau)
                {
                    Console.WriteLine("Tên : {0} , Giá {1}, Giá sau chiết khấu : {2}", sanpham.Ten, sanpham.Gia, sanpham.GiaSauKhiChietKhau);
                }
            }
        }
        public override void DSHienThiTheoChietKhauGiamDan()
        {
            var dsGiamDanTheoChietKhau = sanphams.OrderByDescending(s => s.GiaTriChietKhau);
            foreach (var sanpham in dsGiamDanTheoChietKhau)
            {
                Console.WriteLine("Tên : {0} , Giá {1}, Giá sau chiết khấu : {2}", sanpham.Ten, sanpham.Gia, sanpham.GiaSauKhiChietKhau);
            }

        }
        public override void DSHienThiTheoTenSanPham(string ten)
        {
            foreach (var sanpham in sanphams)
            {
                if (sanpham.Ten.Contains(ten))
                {
                    Console.WriteLine("Tên : {0} , Giá {1}, Giá sau chiết khấu : {2}", sanpham.Ten, sanpham.Gia, sanpham.GiaSauKhiChietKhau);
                }
            }
        }



    }
}
