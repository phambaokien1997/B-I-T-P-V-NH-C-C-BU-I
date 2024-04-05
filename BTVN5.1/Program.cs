using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BTVN5._1
{
    internal class Program
    {
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
                    case 4: NhanVienThamNien();
                        break;

                    default: Environment.Exit(0);
                        break;
                }
            }            
        }
        static void NhapDanhSachNhanVien()
        {
            NhanVien NV;
            Console.WriteLine("Nhập Danh Sách Nhân Viên Vào Đây:");
            Console.WriteLine("Nhập mã nhân viên:");
            NV.maNhanVien = Console.ReadLine();
            Console.WriteLine("Nhập họ đệm:");
            NV.hoDem = Console.ReadLine();
            Console.WriteLine("Nhập tên:");
            NV.ten = Console.ReadLine();
            Console.WriteLine("Nhập ngày tháng năm sinh");
            NV.nSinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhập ngày vào làm:");
            NV.nVaoLam= DateTime.Parse(Console.ReadLine());
            NhanViens.Add(NV);
            Console.WriteLine("Danh sách nhân viên:");
        }
        static void HienThiDanhSach()
        {
            Console.WriteLine("Danh Sách Nhân Viên:");
            if (NhanViens.Count ==0)
            {
                Console.WriteLine("Chưa Có Nhân Viên Nào Trong Danh Sách Thím Ơi!!!!");
            }    
            foreach(var NV in NhanViens)
            {
                Console.WriteLine("Mã nhân viên: {0}, Họ đệm: {1}, Tên: {2}, Ngày tháng năm sinh: {3}, Ngày vào làm : {4}", NV.maNhanVien,NV.hoDem,NV.ten,NV.nSinh,NV.nVaoLam);
            }
        }
        static void SapXep()
        {
            Console.WriteLine("Danh Sách Đã Sắp Xếp Giảm Dần Theo Ngày Sinh Là:");
            //NhanViens.Sort((x, y) => y.nSinh.CompareTo(x.nSinh));
            for(int i = 0; i < NhanViens.Count-1; i++) 
            {
                for (int j = 0; j < NhanViens.Count-1-i; j++)
                {
                    if (NhanViens[j].nSinh < NhanViens[j+1].nSinh)
                    {
                        var tempt = NhanViens[j];
                        NhanViens[j]= NhanViens[j+1];
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
            foreach (var NV in NhanViens )
            {
                TimeSpan khoangThoiGian = DateTime.Now - NV.nVaoLam;
                int soNgay = khoangThoiGian.Days;
                if ( soNgay/365 >=5 )
                {
                    Console.WriteLine("Mã nhân viên: {0}, Họ đệm: {1}, Tên: {2}, Ngày tháng năm sinh: {3}, Ngày vào làm : {4}", NV.maNhanVien, NV.hoDem, NV.ten, NV.nSinh, NV.nVaoLam);
                }    
            }

        }
    }
    
}
