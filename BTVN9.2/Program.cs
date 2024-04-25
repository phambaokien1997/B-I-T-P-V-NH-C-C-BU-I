using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;

            StudentRegister studentRegister = new StudentRegister();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Đăng ký khóa học");
                Console.WriteLine("2. Hiển thị danh sách đăng ký với chiết khấu");
                Console.WriteLine("3. Thoát");
                Console.Write("Chọn chức năng: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Nhập thông tin học viên:");
                        Console.Write("Họ tên: ");
                        string hoTen = Console.ReadLine();
                        if (!Validator.IsValidName(hoTen))
                        {
                            Console.WriteLine("Tên không hợp lệ. Vui lòng nhập lại.");
                            break;
                        }
                        Console.Write("Ngày sinh (dd/MM/yyyy): ");
                        string ngaySinhString = Console.ReadLine();
                        if (!Validator.IsValidDate(ngaySinhString))
                        {
                            Console.WriteLine("Ngày sinh không hợp lệ. Vui lòng nhập lại.");
                            break;
                        }
                        DateTime ngaySinh = DateTime.ParseExact(ngaySinhString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        Student hocVien = new Student { HoTen = hoTen, NgaySinh = ngaySinh };

                        Console.WriteLine("Nhập thông tin khóa học:");
                        Console.Write("Tên khóa học: ");
                        string tenKhoaHoc = Console.ReadLine();
                        Console.Write("Mô tả khóa học: ");
                        string moTaKhoaHoc = Console.ReadLine();
                        Console.Write("Học phí: ");
                        string hocPhiString = Console.ReadLine();
                        if (!Validator.IsValidFee(hocPhiString))
                        {
                            Console.WriteLine("Học phí không hợp lệ. Vui lòng nhập lại.");
                            break;
                        }
                        double hocPhi = double.Parse(hocPhiString);
                        DateTime ngayKhaiGiang = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        Course khoaHoc = new Course { Ten = tenKhoaHoc, MoTa = moTaKhoaHoc, HocPhi = hocPhi, NgayKhaiGiang = ngayKhaiGiang };

                        Console.WriteLine("Nhập ngày đăng ký (dd/MM/yyyy): ");
                        DateTime ngayDangKy = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        studentRegister.Dangky(hocVien, khoaHoc, ngayDangKy);
                        Console.WriteLine("Đăng ký thành công!");
                        break;

                    case "2":
                        studentRegister.DSHienThiDKVoiChietKhau();
                        break;

                    case "3":
                        Console.WriteLine("Thoát chương trình.");
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }

        }
    }
}
