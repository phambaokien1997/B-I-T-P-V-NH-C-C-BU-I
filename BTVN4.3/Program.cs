using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BTVN4_3
{
    internal class Program
    {
        struct HoaDon
        {
            public string maHoaDon;
            public DateTime ngayPhatHanh;
            public int tongTien;
            public int soTienConNo;
            public int trangThaiNo;
            public string tenKhachHang;
        }
        static List<HoaDon> hoaDons = new List<HoaDon>();
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Mời bạn chọn một tác vụ");
                Console.WriteLine("1. Nhập thêm danh sách");
                Console.WriteLine("2. Xem danh sách đã thêm");
                Console.WriteLine("3. Nhập mã hóa đơn muốn xóa:");
                Console.WriteLine("4. Xuất Danh Sách");
                Console.WriteLine("5. Hiển thị các hóa đơn theo mốc thời gian:");
                Console.WriteLine("6 .Xuất hóa đơn ra file text:");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        NhapHoaDon();
                        break;
                    case 2:
                        DanhSachDaNhap();
                        break;
                    case 3:
                        XoaNo();
                        break;
                    case 4:
                        XuatDanhSach();
                        break;
                    case 5:
                        TimeNo();
                        break;
                    case 6:
                        XuatTEXT();
                        break;
                }
            }
        }
        static void NhapHoaDon()
        {
            Console.OutputEncoding = Encoding.UTF8;
            HoaDon HD;
            Console.WriteLine("Nhập Hóa Đơn Đi Nào:");
            Console.WriteLine("Nhập mã hóa đơn");
            HD.maHoaDon = Console.ReadLine();
            Console.WriteLine("Nhập ngày phát hành:");
            HD.ngayPhatHanh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tổng tiền");
            HD.tongTien = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tiền còn nợ:");
            HD.soTienConNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập trạng thái nợ");
            HD.trangThaiNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tên khách hàng:");
            HD.tenKhachHang = Console.ReadLine();

            hoaDons.Add(HD);
            Console.WriteLine("Danh sách hóa đơn:");
        }
        static void DanhSachDaNhap()
        {
            Console.WriteLine("Danh sách hóa đơn đã nhập là:");
            if (hoaDons.Count == 0)
            {
                Console.WriteLine("không có hóa đơn nào thím ơi");
            }
            else
            {
                foreach (var HD in hoaDons)
                {
                    Console.WriteLine("Mã hóa đơn: {0}, ngày phát hành: {1}, tổng tiền :{2}, số tiền còn nợ :{3}, trạng thái nợ {4}, tên khách hàng :{5}", HD.maHoaDon, HD.ngayPhatHanh, HD.tongTien, HD.soTienConNo, HD.trangThaiNo, HD.tenKhachHang);
                }
            }
        }
        static void XoaNo()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chọn mã hóa đơn cần xóa nợ:");
            string timKiemMa = Console.ReadLine();
            for (int i = 0; i < hoaDons.Count; i++)
            {
                if (hoaDons[i].maHoaDon.ToLower().Contains(timKiemMa.ToLower()))
                {
                    HoaDon hoaDonCanXoa = hoaDons[i]; // Tạo một biến trung gian để thay đổi giá trị
                    hoaDonCanXoa.soTienConNo = 0; // Thay đổi giá trị của biến trung gian
                    hoaDonCanXoa.trangThaiNo = 0;
                    hoaDons[i] = hoaDonCanXoa; // Cập nhật lại phần tử trong danh sách
                    Console.WriteLine("Đã xóa nợ cho hóa đơn có mã: {0}", timKiemMa);
                    return; // Thoát khỏi phương thức sau khi xóa nợ     
                }
            }
            Console.WriteLine("Không tìm thấy hóa đơn có mã: {0}", timKiemMa);
        }
        static void XuatDanhSach()
        {
            Console.WriteLine("Nhập vào mã hóa đơn:");
            string mhd = Console.ReadLine();
            foreach(var HD in hoaDons)
            {
                if (HD.maHoaDon.ToLower().Contains(mhd.ToLower()))
                {
                    Console.WriteLine("Mã hóa đơn: {0}, ngày phát hành: {1}, tổng tiền :{2}, số tiền còn nợ :{3}, trạng thái nợ {4}, tên khách hàng :{5}", HD.maHoaDon, HD.ngayPhatHanh, HD.tongTien, HD.soTienConNo, HD.trangThaiNo, HD.tenKhachHang);
                    break;
                }
                else
                {
                    DanhSachDaNhap();
                    break;
                }
            }
        }
        static void TimeNo()
        {
            Console.WriteLine("Các hóa đơn còn nợ theo các mốc là:");       
            foreach (var HD in hoaDons)
            {
                TimeSpan thoiGian = DateTime.Now - HD.ngayPhatHanh;
                int soNgay = thoiGian.Days;
                if (soNgay <= 30 && HD.soTienConNo > 0)
                {
                    Console.WriteLine("Mốc 1 (Dưới 30 ngày) là:Mã hóa đơn: {0}, ngày phát hành: {1}, tổng tiền :{2}, số tiền còn nợ :{3}, trạng thái nợ {4}, tên khách hàng :{5}", HD.maHoaDon, HD.ngayPhatHanh, HD.tongTien, HD.soTienConNo, HD.trangThaiNo, HD.tenKhachHang);
                }
                if (soNgay >30 && soNgay <= 60 && HD.soTienConNo > 0)
                {
                    Console.WriteLine("Mốc 2 (30-60 ngày) là:Mã hóa đơn: {0}, ngày phát hành: {1}, tổng tiền :{2}, số tiền còn nợ :{3}, trạng thái nợ {4}, tên khách hàng :{5}", HD.maHoaDon, HD.ngayPhatHanh, HD.tongTien, HD.soTienConNo, HD.trangThaiNo, HD.tenKhachHang);
                }
                if (soNgay > 60 && soNgay <= 90 && HD.soTienConNo > 0)
                {
                    Console.WriteLine("Mốc 3 (60-90 ngày) là:Mã hóa đơn: {0}, ngày phát hành: {1}, tổng tiền :{2}, số tiền còn nợ :{3}, trạng thái nợ {4}, tên khách hàng :{5}", HD.maHoaDon, HD.ngayPhatHanh, HD.tongTien, HD.soTienConNo, HD.trangThaiNo, HD.tenKhachHang);
                }
                if (soNgay>90 && HD.soTienConNo > 0)
                {
                    Console.WriteLine("Nợ quá lâu không thể chấp nhận được");
                }      
            }     
        }
        static void XuatTEXT()
        {
            Console.WriteLine("===== XUẤT DANH SÁCH HÓA ĐƠN KHÔNG CÒN NỢ RA FILE TEXT =====");
            string filePath = "HoaDonKhongConNo.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var HD in hoaDons)
                    {
                        if (HD.trangThaiNo==0)
                        {
                            writer.WriteLine($"Mã hóa đơn: {HD.maHoaDon}");
                            writer.WriteLine($"Ngày phát hành: {HD.ngayPhatHanh}");
                            writer.WriteLine($"Tổng tiền: {HD.tongTien}");
                            writer.WriteLine($"Tên khách hàng: {HD.tenKhachHang}");
                            writer.WriteLine();
                        }
                    }
                }

                Console.WriteLine($"Đã xuất danh sách hóa đơn không còn nợ ra file: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
    
}
