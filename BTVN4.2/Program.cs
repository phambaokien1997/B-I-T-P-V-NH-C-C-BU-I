using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN4_2
{
    struct Hocsinh
    {
        public string ten;
        public int tuoi;
        public float diemtrungbinh;
    }
    internal class Program
    {

        static List<Hocsinh> Hocsinhs = new List<Hocsinh>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Mời bạn chọn một tác vụ:");
                Console.WriteLine("1. Thêm học sinh mới vào danh sách.");
                Console.WriteLine("2. Hiển thị danh sách các học sinh đã thêm.");
                Console.WriteLine("3. Tìm kiếm học sinh theo tên.");
                Console.WriteLine("4. Thoát chương trình");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ThemHocSinh();
                        break;
                    case 2:
                        DanhSachHocSinh();
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
        static void ThemHocSinh()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập thông tin học sinh");
            Hocsinh HS;

            Console.WriteLine("Mời bạn nhập tên hs:");
            HS.ten = Console.ReadLine();

            Console.WriteLine("Mời bạn nhập tuổi hs:");
            //HS.tuoi = int.Parse(Console.ReadLine());
            bool validTuoi = int.TryParse(Console.ReadLine(), out HS.tuoi);
            if (!validTuoi)
            {
                Console.WriteLine("Tuổi phải là một số nguyên. Vui lòng nhập lại.");
                return;
            }
            Console.WriteLine("Mời bạn nhập điểm trung bình của hs:");
            //HS.diemtrungbinh = float.Parse(Console.ReadLine());
            bool validDiem = float.TryParse(Console.ReadLine(), out HS.diemtrungbinh);
            if (!validDiem)
            {
                Console.WriteLine("Điểm của bạn phải là một số. Vui lòng nhập lại");
                return;
            }

            Hocsinhs.Add(HS);
            Console.WriteLine("Danh sách học sinh đã được thêm");


        }
        static void DanhSachHocSinh()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Danh sách học sinh đã thêm:");
            if (Hocsinhs.Count == 0)
            {
                Console.WriteLine("Danh sách trống");
            }
            else
            {
                foreach (var HS in Hocsinhs)
                {
                    Console.WriteLine($"Tên: {HS.ten}, Tuổi: {HS.tuoi}, Điểm trung bình: {HS.diemtrungbinh}");
                }
            }
        }
        static void FindDs()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập tên HS cần tìm vào đây");
            string dongTimKiem = Console.ReadLine();
            bool kq = false;
            foreach (var HS in Hocsinhs)
            {
                if (HS.ten.ToLower().Contains(dongTimKiem.ToLower()))
                {
                    Console.WriteLine($"Tên: {HS.ten}, Tuổi: {HS.tuoi}, Điểm trung bình: {HS.diemtrungbinh}");
                    kq = true;
                }

            }
            if (!kq)
            {
                Console.WriteLine("Không tìm thấy tên học sinh cần tìm:");
            }


        }
    }


}
