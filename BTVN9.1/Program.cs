using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            ConcreteProductManager quanLySanPham = new ConcreteProductManager();
            while(true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Thêm một sản phẩm.");
                Console.WriteLine("2. Tính giá  sau khi chiết khấu.");
                Console.WriteLine("3. Hiển thị danh sách sản phẩm theo chiết khấu.");
                Console.WriteLine("4. Hiển thị danh sách sản phẩm theo chiết khấu giảm dần");
                Console.WriteLine("5. Hiển thị sản phẩm theo tên.");
                Console.WriteLine("6. Exit.");
                Console.Write("Mời bạn chọn 1 tác vụ!!");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: 
                        quanLySanPham.NhapSanPham();
                        break;
                    case 2: 
                        quanLySanPham.GiaSauKhiTinhToanXong();
                        break;
                    case 3:
                        Console.WriteLine("Chọn loại chiết khấu (0. Theo tiền:  , 1. Theo phần trăm:");
                        int giaTriChon = Convert.ToInt32(Console.ReadLine());
                        quanLySanPham.DSHienThiTheoChietKhau((Loaichietkhau)giaTriChon);
                        break;
                    case 4:
                        quanLySanPham.DSHienThiTheoChietKhauGiamDan();
                        break;
                    case 5:
                        Console.WriteLine("Nhập tên sản phẩm vô đây thím ơi:");
                        string ten = Console.ReadLine();
                        quanLySanPham.DSHienThiTheoTenSanPham(ten);
                        break;
                    case 6: Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nhập không đúng tác vụ rồi ba!!");
                        break;
                }

            }    
        }
    }
}
