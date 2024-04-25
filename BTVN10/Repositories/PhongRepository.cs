using BTVN10.Interfaces;
using BTVN10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Repositories
{
    public class PhongRepository : IPhongRepository
    {
        private List<Phong> danhSachPhong = new List<Phong>();

        public void ThemPhong(Phong phong)
        {
            try
            {
                danhSachPhong.Add(phong);
                Console.WriteLine($"Thêm phòng: {phong}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm phòng: {ex.Message}");
                // Hoặc có thể throw lại ngoại lệ để thông báo lên tầng gọi
                throw;
            }
        }

        public void SuaThongTinPhong(int maPhong, Phong phong)
        {
            Phong phongCanSua = danhSachPhong.Find(p => p.MaPhong == maPhong);
            if (phongCanSua != null)
            {
                try
                {
                    // Thực hiện sửa thông tin phòng
                    phongCanSua.TenPhong = phong.TenPhong;
                    phongCanSua.LoaiPhong = phong.LoaiPhong;
                    phongCanSua.GiaPhong = phong.GiaPhong;
                    phongCanSua.TrangThai = phong.TrangThai;
                    Console.WriteLine($"Sửa thông tin phòng mã {maPhong}: {phongCanSua}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi sửa thông tin phòng mã {maPhong}: {ex.Message}");
                    // Hoặc có thể throw lại ngoại lệ để thông báo lên tầng gọi
                    throw;
                }
            }
            else
            {
                Console.WriteLine($"Không tìm thấy phòng mã {maPhong}");
            }
        }

        public void XoaPhong(int maPhong)
        {
            Phong phongCanXoa = danhSachPhong.Find(p => p.MaPhong == maPhong);
            if (phongCanXoa != null)
            {
                try
                {
                    // Xóa phòng khỏi danh sách
                    danhSachPhong.Remove(phongCanXoa);
                    Console.WriteLine($"Xóa phòng mã {maPhong}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi xóa phòng mã {maPhong}: {ex.Message}");
                    // Hoặc có thể throw lại ngoại lệ để thông báo lên tầng gọi
                    throw;
                }
            }
            else
            {
                Console.WriteLine($"Không tìm thấy phòng mã {maPhong}");
            }
        }

        public List<Phong> LayDanhSachPhong()
        {
            return danhSachPhong;
        }

        public Phong TimPhongTheoMa(int maPhong)
        {
            return danhSachPhong.Find(phong => phong.MaPhong == maPhong);
        }

    }
}
