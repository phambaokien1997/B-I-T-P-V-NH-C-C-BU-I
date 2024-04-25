using BTVN10.Interfaces;
using BTVN10.Models;
using BTVN10.Repositories;
using BTVN10.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo các repository
            var phongRepo = new PhongRepository();
            var loaiPhongRepo = new LoaiPhongRepository();
            var khachHangRepo = new KhachHangRepository();
            var datPhongRepo = new DatPhongRepository();
            var thanhToanRepo = new ThanhToanRepository();

            // Khởi tạo các service
            var quanLyPhongService = new QuanLyPhongService(phongRepo, loaiPhongRepo);
            var khachHangService = new KhachHangService(khachHangRepo);
            var datPhongService = new DatPhongService(datPhongRepo, phongRepo, khachHangRepo);
            var thanhToanService = new ThanhToanService(loaiPhongRepo);

            // Thêm một số loại phòng
            var loaiPhong1 = new LoaiPhong(1, "Loại 1");
            var loaiPhong2 = new LoaiPhong(2, "Loại 2");
            quanLyPhongService.ThemLoaiPhong(loaiPhong1);
            quanLyPhongService.ThemLoaiPhong(loaiPhong2);

            // Thêm một số phòng
            var phong1 = new Phong(101, "Phòng 101", loaiPhong1, 100, true);
            var phong2 = new Phong(102, "Phòng 102", loaiPhong2, 120, true);
            quanLyPhongService.ThemPhong(phong1);
            quanLyPhongService.ThemPhong(phong2);

            // Hiển thị danh sách phòng
            Console.WriteLine("Danh sách phòng sau khi thêm:");
            quanLyPhongService.HienThiDanhSachPhong();

            // Thêm một khách hàng
            var khachHang = new KhachHang(1, "Nguyễn Văn A", "123456789", "nguyenvana@gmail.com", "Đà Nẵng");
            khachHangService.ThemKhachHang(khachHang);

            // Đặt phòng
            
            var ngayDat = DateTime.Now;
            var ngayNhan = ngayDat.AddDays(3);
            var ngayTra = ngayDat.AddDays(5);
            DatPhong maDatPhong = datPhongService.DatPhong(phong1.MaPhong, khachHang.MaKhachHang, ngayDat, ngayNhan, ngayTra);

            if (maDatPhong != null)
            {
                Console.WriteLine($"Đã đặt phòng thành công. Mã đặt phòng: {maDatPhong.MaDatPhong}");
            }
            else
            {
                Console.WriteLine("Đặt phòng không thành công.");
            }

            // Hiển thị danh sách phòng sau khi đặt
            Console.WriteLine("\nDanh sách phòng sau khi đặt:");
            quanLyPhongService.HienThiDanhSachPhong();

            // Thanh toán
            var phong101 = phongRepo.TimPhongTheoMa(phong1.MaPhong);
            var datPhong = datPhongRepo.LayDanhSachDatPhong().Find(dp => dp.MaPhong == phong1.MaPhong);
            var thanhToan = thanhToanService.TinhTongTienThue(phong101, datPhong.NgayDat, datPhong.NgayTra, datPhong.MaDatPhong, datPhong.MaKhachHang, datPhong.MaPhong);

            if (thanhToan != null)
            {
                thanhToanRepo.ThemThanhToan(thanhToan);
                Console.WriteLine($"\nTổng tiền cần thanh toán cho đặt phòng mã {datPhong.MaDatPhong}: {thanhToan.TongTien}");
            }
            else
            {
                Console.WriteLine("Không thể tính tổng tiền thanh toán.");
            }
        }
    }
}
