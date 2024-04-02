using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BT4._3
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
                }

            }

        }
        static void NhapHoaDon()
        {
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
            Console.WriteLine("Chọn mã hóa đơn cần xóa nợ:");
            string timKiemMa = Console.ReadLine();

            for (int i = 0; i < hoaDons.Count; i++)
            {
                if (hoaDons[i].maHoaDon.ToLower().Contains(timKiemMa.ToLower()))
                {
                    HoaDon hoaDonCanXoa = hoaDons[i]; // Tạo một biến trung gian để thay đổi giá trị
                    hoaDonCanXoa.soTienConNo = 0; // Thay đổi giá trị của biến trung gian
                    hoaDons[i] = hoaDonCanXoa; // Cập nhật lại phần tử trong danh sách
                    Console.WriteLine("Đã xóa nợ cho hóa đơn có mã: {0}", timKiemMa);
                    return; // Thoát khỏi phương thức sau khi xóa nợ
                }
            }

            Console.WriteLine("Không tìm thấy hóa đơn có mã: {0}", timKiemMa);
        }

    }
}
