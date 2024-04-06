using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BTVN5._1
{
    internal class Program
    {
        static public bool ContainerNumber(string input)
        {
            if (input.Any(char.IsDigit))
            {
                Console.WriteLine("Không được chứa chữ số");
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool CheckContainerSpecialChar(string input)
        {
            Regex specialCharRegex = new Regex(@"[~`!@#$%^&*()+=|\\{}':;,.<>?/""-]");
            if (specialCharRegex.IsMatch(input))
            {
                Console.WriteLine("Không được nhập kí tự đặc biệt.");
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool CheckIsNullOrWhiteSpace(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Không được để trống hoặc chứa khoảng trắng.");
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool CheckBirthday(string input)
        {
            if (DateTime.TryParseExact(input, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                DateTime now = DateTime.Now;
                TimeSpan interval = now - date;
                if (interval.Days > 0)
                {
                    int valid = now.Year - date.Year;
                    if (valid >= 16)
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Tuổi nhân viên phải lớn hơn hoặc bằng 16 tuổi...");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Thật vô lý khi chưa sinh ra đã đi làm.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Bạn đã nhập sai định dạng của ngày (cú pháp đúng : tháng/ngày/năm");
                return false;
            }
        }
        static public bool CheckNgayLam(string input)
        {
            if (DateTime.TryParseExact(input, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                DateTime now = DateTime.Now;
                TimeSpan interval = now - date;
                if (interval.Days > 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Ngày vào làm không được trễ hơn ngày hiện tại(vô lý)");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Bạn đã nhập sai định dạng của ngày (cú pháp đúng : tháng/ngày/năm");
                return false;
            }
        }
        struct NhanVien
        {
            public string maNhanVien;
            public string hoDem;
            public string ten;
            public DateTime nSinh;
            public DateTime nVaoLam;

        }
        static List<NhanVien> NhanViens = new List<NhanVien>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Mời bạn chọn một tác vụ:");
                Console.WriteLine("1. Nhập Danh Sách Nhân Viên:");
                Console.WriteLine("2. Hiển Thị Danh Sách Nhân Viên:");
                Console.WriteLine("3. Sắp Xếp DS Nhân Viên Theo Thứ Tự Ngày Sinh Giảm Dần");
                Console.WriteLine("4. Hiển Thị Danh Sách Nhân Viên Có Số Năm Làm Việc Hơn 5 Năm:");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        NhapDanhSachNhanVien();
                        break;
                    case 2:
                        HienThiDanhSach();
                        break;
                    case 3:
                        SapXep();
                        break;
                    case 4:
                        NhanVienThamNien();
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void NhapDanhSachNhanVien()
        {

            NhanVien NV;
            Console.WriteLine("Nhập Danh Sách Nhân Viên Vào Đây:");
            do
            {
                Console.WriteLine("Nhập mã nhân viên:");
                NV.maNhanVien = Console.ReadLine();
            }
            while (CheckIsNullOrWhiteSpace(NV.maNhanVien) || CheckContainerSpecialChar(NV.maNhanVien));
            do {
                Console.WriteLine("Nhập họ đệm:");
                NV.hoDem = Console.ReadLine();
            }
            while(CheckIsNullOrWhiteSpace(NV.hoDem) || CheckContainerSpecialChar(NV.hoDem) || ContainerNumber(NV.hoDem));
            do {
                Console.WriteLine("Nhập tên:");
                NV.ten = Console.ReadLine();
            }
            while (CheckIsNullOrWhiteSpace(NV.ten) || CheckContainerSpecialChar(NV.ten) || ContainerNumber(NV.ten));
            Console.WriteLine("Nhập ngày tháng năm sinh");
            NV.nSinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhập ngày vào làm:");
            NV.nVaoLam = DateTime.Parse(Console.ReadLine());

            NhanViens.Add(NV);
            Console.WriteLine("Danh sách nhân viên:");


        }
        static void HienThiDanhSach()
        {
            Console.WriteLine("Danh Sách Nhân Viên:");
            if (NhanViens.Count == 0)
            {
                Console.WriteLine("Chưa Có Nhân Viên Nào Trong Danh Sách Thím Ơi!!!!");
            }
            foreach (var NV in NhanViens)
            {
                Console.WriteLine("Mã nhân viên: {0}, Họ đệm: {1}, Tên: {2}, Ngày tháng năm sinh: {3}, Ngày vào làm : {4}", NV.maNhanVien, NV.hoDem, NV.ten, NV.nSinh, NV.nVaoLam);
            }
        }
        static void SapXep()
        {
            Console.WriteLine("Danh Sách Đã Sắp Xếp Giảm Dần Theo Ngày Sinh Là:");
            //NhanViens.Sort((x, y) => y.nSinh.CompareTo(x.nSinh));
            for (int i = 0; i < NhanViens.Count - 1; i++)
            {
                for (int j = 0; j < NhanViens.Count - 1 - i; j++)
                {
                    if (NhanViens[j].nSinh < NhanViens[j + 1].nSinh)
                    {
                        var tempt = NhanViens[j];
                        NhanViens[j] = NhanViens[j + 1];
                        NhanViens[j + 1] = tempt;
                    }
                }
            }
            foreach (var NV in NhanViens)
            {
                Console.WriteLine("Mã nhân viên: {0}, Họ đệm: {1}, Tên: {2}, Ngày tháng năm sinh: {3}, Ngày vào làm : {4}", NV.maNhanVien, NV.hoDem, NV.ten, NV.nSinh, NV.nVaoLam);
            }
            //HienThiDanhSach();
        }
        static void NhanVienThamNien()
        {
            Console.WriteLine("Danh sách nhân viên có số năm làm trên 5 năm là:");
            foreach (var NV in NhanViens)
            {
                TimeSpan khoangThoiGian = DateTime.Now - NV.nVaoLam;
                int soNgay = khoangThoiGian.Days;
                if (soNgay / 365 >= 5)
                {
                    Console.WriteLine("Mã nhân viên: {0}, Họ đệm: {1}, Tên: {2}, Ngày tháng năm sinh: {3}, Ngày vào làm : {4}", NV.maNhanVien, NV.hoDem, NV.ten, NV.nSinh, NV.nVaoLam);
                }
            }

        }
    }

}
