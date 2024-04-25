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
    public class QuanLyPhongService : IQuanLyPhongService
    {
        private PhongRepository phongRepository;
        private LoaiPhongRepository loaiPhongRepository;

        public QuanLyPhongService(PhongRepository phongRepository, LoaiPhongRepository loaiPhongRepository)
        {
            this.phongRepository = phongRepository;
            this.loaiPhongRepository = loaiPhongRepository;
        }

        public void ThemPhong(Phong phong)
        {
            try
            {
                if (phongRepository.TimPhongTheoMa(phong.MaPhong) != null)
                {
                    Console.WriteLine("Phòng đã tồn tại trong hệ thống.");
                    return;
                }

                phongRepository.ThemPhong(phong);
                Console.WriteLine("Thêm phòng thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm phòng: {ex.Message}");
            }
        }

        // Phương thức xóa phòng
        public void XoaPhong(int maPhong)
        {
            try
            {
                Phong phong = phongRepository.TimPhongTheoMa(maPhong);
                if (phong == null)
                {
                    Console.WriteLine("Không tìm thấy phòng cần xóa.");
                    return;
                }

                phongRepository.XoaPhong(maPhong);
                Console.WriteLine("Xóa phòng thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa phòng: {ex.Message}");
            }
        }
        public void SuaThongTinPhong(int maPhong, Phong thongTinMoi)
        {
            // Kiểm tra xem phòng có tồn tại trong hệ thống không
            Phong phong = phongRepository.TimPhongTheoMa(maPhong);
            if (phong == null)
            {
                Console.WriteLine("Không tìm thấy phòng cần sửa thông tin.");
                return;
            }

            // Sửa thông tin của phòng
            phongRepository.SuaThongTinPhong(maPhong, thongTinMoi);
            Console.WriteLine("Sửa thông tin phòng thành công.");
        }

        public void HienThiDanhSachPhong()
        {
            List<Phong> danhSachPhong = phongRepository.LayDanhSachPhong();
            if (danhSachPhong.Count == 0)
            {
                Console.WriteLine("Danh sách phòng trống.");
                return;
            }

            Console.WriteLine("Danh sách phòng:");
            foreach (var phong in danhSachPhong)
            {
                Console.WriteLine(phong.ToString());
            }
        }

        

        // Phương thức thêm loại phòng
        public void ThemLoaiPhong(LoaiPhong loaiPhong)
        {
            try
            {
                if (loaiPhongRepository.TimLoaiPhongTheoMa(loaiPhong.MaLoaiPhong) != null)
                {
                    Console.WriteLine("Loại phòng đã tồn tại trong hệ thống.");
                    return;
                }

                loaiPhongRepository.ThemLoaiPhong(loaiPhong);
                Console.WriteLine("Thêm loại phòng thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm loại phòng: {ex.Message}");
            }
        }

        // Phương thức xóa loại phòng
        public void XoaLoaiPhong(int maLoaiPhong)
        {
            try
            {
                LoaiPhong loaiPhong = loaiPhongRepository.TimLoaiPhongTheoMa(maLoaiPhong);
                if (loaiPhong == null)
                {
                    Console.WriteLine("Không tìm thấy loại phòng cần xóa.");
                    return;
                }

                loaiPhongRepository.XoaLoaiPhong(maLoaiPhong);
                Console.WriteLine("Xóa loại phòng thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa loại phòng: {ex.Message}");
            }
        }

        // Phương thức sửa thông tin loại phòng
        public void SuaThongTinLoaiPhong(int maLoaiPhong, LoaiPhong thongTinMoi)
        {
            try
            {
                LoaiPhong loaiPhong = loaiPhongRepository.TimLoaiPhongTheoMa(maLoaiPhong);
                if (loaiPhong == null)
                {
                    Console.WriteLine("Không tìm thấy loại phòng cần sửa thông tin.");
                    return;
                }

                loaiPhongRepository.SuaThongTinLoaiPhong(maLoaiPhong, thongTinMoi);
                Console.WriteLine("Sửa thông tin loại phòng thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi sửa thông tin loại phòng: {ex.Message}");
            }
        }

        // Phương thức hiển thị danh sách loại phòng
        public void HienThiDanhSachLoaiPhong()
        {
            try
            {
                List<LoaiPhong> danhSachLoaiPhong = loaiPhongRepository.LayDanhSachLoaiPhong();
                if (danhSachLoaiPhong.Count == 0)
                {
                    Console.WriteLine("Danh sách loại phòng trống.");
                    return;
                }

                Console.WriteLine("Danh sách loại phòng:");
                foreach (var loaiPhong in danhSachLoaiPhong)
                {
                    Console.WriteLine(loaiPhong.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi hiển thị danh sách loại phòng: {ex.Message}");
            }
        }
        
    }
}
