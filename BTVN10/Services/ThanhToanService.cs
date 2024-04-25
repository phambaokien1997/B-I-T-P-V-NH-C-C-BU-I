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
    public class ThanhToanService : IThanhToanService
    {
        private LoaiPhongRepository loaiPhongRepository;

        public ThanhToanService(LoaiPhongRepository loaiPhongRepo)
        {
            loaiPhongRepository = loaiPhongRepo;
        }

        public ThanhToan TinhTongTienThue(Phong phong, DateTime ngayDat, DateTime ngayTra, int maDatPhong, int maKhachHang, int maPhong)
        {
            try
            {
                // Kiểm tra tính hợp lệ của đối tượng phòng
                if (phong == null || phong.GiaPhong <= 0)
                {
                    throw new ArgumentException("Thông tin loại phòng không hợp lệ.");
                }

                // Kiểm tra tính hợp lệ của ngày đặt và ngày trả
                if (ngayDat >= ngayTra || ngayDat < DateTime.Now || ngayTra < DateTime.Now)
                {
                    throw new ArgumentException("Ngày đặt và ngày trả không hợp lệ.");
                }

                // Kiểm tra tính hợp lệ của các mã tương ứng
                if (maDatPhong <= 0 || maKhachHang <= 0 || maPhong <= 0)
                {
                    throw new ArgumentException("Các mã đặt phòng, khách hàng và phòng không hợp lệ.");
                }

                // Tiến hành tính toán tổng tiền thuê
                decimal giaPhong = phong.GiaPhong;
                int soNgayThue = (int)(ngayTra - ngayDat).TotalDays;
                decimal tongTienThue = giaPhong * soNgayThue;

                ThanhToan thanhToan = new ThanhToan();
                thanhToan.TongTien = tongTienThue;
                thanhToan.MaDatPhong = maDatPhong; // Gán mã đặt phòng
                thanhToan.MaKhachHang = maKhachHang; // Gán mã khách hàng
                thanhToan.MaPhong = maPhong; // Gán mã phòng
                thanhToan.NgayDat = ngayDat; // Gán ngày đặt phòng
                thanhToan.NgayTra = ngayTra; // Gán ngày trả phòng

                return thanhToan;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tính tổng tiền thuê: {ex.Message}");
                return null;
            }
        }

    }
}
