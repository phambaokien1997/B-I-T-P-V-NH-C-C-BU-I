using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN7._2Quản_lý
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Employee> employees = new List<Employee>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Nhập vào N nhân viên");
                Console.WriteLine("2. Tính toán lương tương ứng cho mỗi loại nhân viên");
                Console.WriteLine("3. Thoát");
                Console.Write("Chọn chức năng: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        InputEmployees(employees);
                        break;
                    case "2":
                        TinhLuong(employees);
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ!");
                        break;
                }
            }
        }
        static void InputEmployees(List<Employee> employees)
        {
            Console.Write("Nhập số lượng nhân viên: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine($"Nhập thông tin nhân viên {i + 1}:");
                Console.Write("Tên nhân viên: ");
                string Ten = Console.ReadLine();
                Console.Write("Loại nhân viên (Full Time, Part Time, Intern): ");
                string loaiNhanVien = Console.ReadLine();

                switch (loaiNhanVien.ToLower())
                {
                    case "full time":
                        Console.Write("Lương tháng: ");
                        double LuongHangThang = Convert.ToDouble(Console.ReadLine());
                        employees.Add(new FullTimeEmployee(Ten, LuongHangThang));
                        break;
                    case "part time":
                        Console.Write("Lương giờ: ");
                        double Tien1Gio = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Số giờ làm việc: ");
                        double SoGioDaLam = Convert.ToDouble(Console.ReadLine());
                        employees.Add(new PartTimeEmployee(Ten, Tien1Gio, SoGioDaLam));
                        break;
                    case "intern":
                        Console.Write("Tiền trợ cấp: ");
                        double TienTra = Convert.ToDouble(Console.ReadLine());
                        employees.Add(new Intern(Ten, TienTra));
                        break;
                    default:
                        Console.WriteLine("Loại nhân viên không hợp lệ!");
                        break;
                }
            }
        }
        static void TinhLuong(List<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                if (emp is FullTimeEmployee)
                {
                    FullTimeEmployee fullTimeEmp = (FullTimeEmployee)emp;

                    Console.WriteLine("Lương của nhân viên {0} là {1}", emp.Ten, fullTimeEmp.TinhLuong());
                }
                else if (emp is PartTimeEmployee)
                {
                    PartTimeEmployee partTimeEmp = (PartTimeEmployee)emp;
                    Console.WriteLine("Lương của nhân viên {0} là {1}", emp.Ten, partTimeEmp.TinhLuong());
                }
                else if (emp is Intern)
                {
                    Intern intern = (Intern)emp;
                    Console.WriteLine("Lương của nhân viên {0} là {1}", emp.Ten, intern.TinhLuong());
                }
            }
        }
    }
}
