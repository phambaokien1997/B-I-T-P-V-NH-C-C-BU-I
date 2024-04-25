using BTVN10.Interfaces;
using BTVN10.Models;
using BTVN10.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Services
{
     public class DatPhongService : IDatPhongService
     {
        private DatPhongRepository datPhongRepository;
        private PhongRepository phongRepository;
        private KhachHangRepository khachHangRepository;

        public DatPhongService(DatPhongRepository datPhongRepo, PhongRepository phongRepo, KhachHangRepository khachHangRepo)
        {
            this.datPhongRepository = datPhongRepo;
            this.phongRepository = phongRepo;
            this.khachHangRepository = khachHangRepo;
        }

        public void DatPhong(int maPhong, int maKhachHang, DateTime ngayDat, DateTime ngayNhan, DateTime ngayTra)
        {
            try
            {
                Phong phong = phongRepository.TimPhongTheoMa(maPhong);
                KhachHang khachHang = khachHangRepository.TimKhachHangTheoMa(maKhachHang);

                if (phong == null || khachHang == null)
                {
                    Console.WriteLine("Không thể đặt phòng vì mã phòng hoặc mã khách hàng không hợp lệ.");
                    return;
                }

                // Kiểm tra xem phòng đã được đặt trong thời gian đó chưa
                bool isAvailable = datPhongRepository.KiemTraPhongTrongThoiGian(maPhong, ngayNhan, ngayTra);
                if (!isAvailable)
                {
                    Console.WriteLine("Không thể đặt phòng vì phòng đã được đặt trong thời gian đó.");
                    return;
                }

                // Tạo đối tượng Đặt phòng mới
                DatPhong datPhong = new DatPhong(maKhachHang, maPhong, ngayDat, ngayNhan, ngayTra);

                // Thêm đặt phòng vào repository
                datPhongRepository.ThemDatPhong(datPhong);

                Console.WriteLine("Đặt phòng thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đặt phòng: {ex.Message}");
            }
        }

        public void HuyDatPhong(int maPhong, DateTime ngayNhan, DateTime ngayTra)
        {
            try
            {
                // Kiểm tra xem có đặt phòng nào trong thời gian này không
                DatPhong datPhong = datPhongRepository.TimDatPhongTheoPhongVaThoiGian(maPhong, ngayNhan, ngayTra);
                if (datPhong == null)
                {
                    Console.WriteLine("Không có đặt phòng nào trong thời gian này.");
                    return;
                }

                // Hủy đặt phòng
                datPhongRepository.XoaDatPhong(datPhong.MaDatPhong);

                Console.WriteLine("Hủy đặt phòng thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi hủy đặt phòng: {ex.Message}");
            }
        }
    }
}
