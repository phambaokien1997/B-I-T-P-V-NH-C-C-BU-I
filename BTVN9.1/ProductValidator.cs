using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN9._1
{
    public class ProductValidator
    {
        public static bool ValidateProductName(string ten)
        {
            // Kiểm tra xem tên sản phẩm có rỗng không
            if (string.IsNullOrWhiteSpace(ten))
            {
                Console.WriteLine("Tên sản phẩm không được để trống!");
                return false;
            }
            return true;
        }

        public static bool ValidateProductPrice(double gia)
        {
            // Kiểm tra xem giá sản phẩm có âm không
            if (gia < 0)
            {
                Console.WriteLine("Giá sản phẩm không được âm!");
                return false;
            }
            return true;
        }

        public static bool ValidateDiscountType(Loaichietkhau loaiChietKhau, double giaTriChietKhau)
        {
            // Kiểm tra giá trị chiết khấu theo loại
            if (loaiChietKhau == Loaichietkhau.TheoSoTien && giaTriChietKhau < 0)
            {
                Console.WriteLine("Giá trị triết khấu phải lớn hơn hoặc bằng 0!");
                return false;
            }
            if (loaiChietKhau == Loaichietkhau.TheoPhanTram && (giaTriChietKhau < 0 || giaTriChietKhau > 100))
            {
                Console.WriteLine("Giá trị triết khấu phải từ 0-100 khi chiết khấu theo phần trăm!");
                return false;
            }
            return true;
        }
    }
}
