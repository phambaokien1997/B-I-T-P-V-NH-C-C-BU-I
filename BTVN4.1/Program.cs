using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BTVN4
{

    struct Sach
    {
        public string TieuDe;
        public string TacGia;
        public int NamSx;
    }

    internal class Program
    {
        static List<Sach> books = new List<Sach>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("1. Thêm sách mới");
                Console.WriteLine("2. Hiển thị danh sách các sách đã thêm");
                Console.WriteLine("3. Tìm kiếm sách theo tiêu đề");
                Console.WriteLine("4. Thoát chương trình");
                Console.Write("Chọn chức năng: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        NhapThongTinSach(out Sach BK);
                        break;
                    case 2:
                        Dsdn();
                        break;
                    case 3:
                        FindDs();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }
        }
        static void NhapThongTinSach(out Sach BK)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập thông tin sách:");

            Console.WriteLine("tiêu đề:");
            BK.TieuDe = Console.ReadLine();
            Console.WriteLine("tác giả:");
            BK.TacGia = Console.ReadLine();
            Console.WriteLine("năm sản xuât:");
            BK.NamSx = int.Parse(Console.ReadLine());
            books.Add(BK);

            Console.WriteLine("Sách đã được thêm vào danh sách");

        }
        static void Dsdn()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Danh sách các sách đã thêm:");

            if (books.Count == 0)
            {
                Console.WriteLine("Danh sách sách trống.");
            }
            else
            {
                foreach (var BK in books)
                {
                    Console.WriteLine($"Tiêu đề: {BK.TieuDe}, Tác giả: {BK.TacGia}, Năm xuất bản: {BK.NamSx}");
                }
            }
        }
        static void FindDs()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập sách cần tìm vào đây:");
            string dongTimKiem = Console.ReadLine();
            bool kq = false;
            foreach (var BK in books)
            {
                if (BK.TieuDe.ToLower().Contains(dongTimKiem.ToLower()))
                {
                    Console.WriteLine($"Tiêu đề: {BK.TieuDe}, Tác giả: {BK.TacGia}, Năm xuất bản: {BK.NamSx}");
                    kq = true;
                }

            }
            if (!kq)
            {
                Console.WriteLine("Không tìm thấy sách bạn cần tìm");
            }
        }
    }
}
