using BTVN10.Interfaces;
using BTVN10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Repositories
{
        public class LoaiPhongRepository : ILoaiPhongRepository
        {
            private List<LoaiPhong> danhSachLoaiPhong = new List<LoaiPhong>();

            public void ThemLoaiPhong(LoaiPhong loaiPhong)
            {
                try
                {
                    danhSachLoaiPhong.Add(loaiPhong);
                    Console.WriteLine($"Thêm loại phòng: {loaiPhong}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi thêm loại phòng: {ex.Message}");
                    // Hoặc có thể throw lại ngoại lệ để thông báo lên tầng gọi
                    throw;
                }
            }
            public void XoaLoaiPhong(int maLoaiPhong)
            {
                LoaiPhong loaiPhongCanXoa = danhSachLoaiPhong.Find(l => l.MaLoaiPhong == maLoaiPhong);
                if (loaiPhongCanXoa != null)
                {
                    try
                    {
                        danhSachLoaiPhong.Remove(loaiPhongCanXoa);
                        Console.WriteLine($"Xóa loại phòng mã {maLoaiPhong}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi xóa loại phòng mã {maLoaiPhong}: {ex.Message}");
                        // Hoặc có thể throw lại ngoại lệ để thông báo lên tầng gọi
                        throw;
                    }
                }
                else
                {
                    Console.WriteLine($"Không tìm thấy loại phòng mã {maLoaiPhong}");
                }
            }
            public LoaiPhong TimLoaiPhongTheoMa(int maLoaiPhong)
            {
                LoaiPhong loaiPhong = danhSachLoaiPhong.Find(l => l.MaLoaiPhong == maLoaiPhong);
                if (loaiPhong == null)
                {
                    throw new KeyNotFoundException($"Không tìm thấy loại phòng mã {maLoaiPhong}");
                }
                return loaiPhong;
            }
            public void SuaThongTinLoaiPhong(int maLoaiPhong, LoaiPhong thongTinMoi)
            {
                LoaiPhong loaiPhongCanSua = danhSachLoaiPhong.Find(l => l.MaLoaiPhong == maLoaiPhong);
                if (loaiPhongCanSua != null)
                {
                    loaiPhongCanSua.TenLoaiPhong = thongTinMoi.TenLoaiPhong;
                    Console.WriteLine($"Sửa thông tin loại phòng mã {maLoaiPhong}: {loaiPhongCanSua}");
                }
                else
                {
                    throw new KeyNotFoundException($"Không tìm thấy loại phòng mã {maLoaiPhong}");
                }
            }
            public List<LoaiPhong> LayDanhSachLoaiPhong()
            {
                return danhSachLoaiPhong;
            }
        }
}
