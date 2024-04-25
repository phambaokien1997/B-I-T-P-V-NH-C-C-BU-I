using BTVN10.Interfaces;
using BTVN10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Repositories
{
    public class DatPhongRepository : IDatPhongRepository
    {
        // Giả sử có một danh sách các thông tin đặt phòng trong cơ sở dữ liệu
        private List<DatPhong> danhSachDatPhong = new List<DatPhong>();

        // Phương thức để thêm thông tin đặt phòng vào danh sách
        public void ThemDatPhong(DatPhong datPhong)
        {
            try
            {
                danhSachDatPhong.Add(datPhong);
                Console.WriteLine($"Thêm thông tin đặt phòng: {datPhong}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm thông tin đặt phòng: {ex.Message}");
                // Hoặc có thể throw lại ngoại lệ để thông báo lên tầng gọi
                throw;
            }
        }

        // Phương thức để xóa thông tin đặt phòng khỏi danh sách
        public void XoaDatPhong(int maDatPhong)
        {
            try
            {
                DatPhong datPhongCanXoa = danhSachDatPhong.Find(d => d.MaDatPhong == maDatPhong);
                if (datPhongCanXoa != null)
                {
                    danhSachDatPhong.Remove(datPhongCanXoa);
                    Console.WriteLine($"Xóa thông tin đặt phòng mã {maDatPhong}");
                }
                else
                {
                    Console.WriteLine($"Không tìm thấy thông tin đặt phòng mã {maDatPhong}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa thông tin đặt phòng: {ex.Message}");
                // Hoặc có thể throw lại ngoại lệ để thông báo lên tầng gọi
                throw;
            }
        }

        // Phương thức để lấy danh sách tất cả các thông tin đặt phòng
        public List<DatPhong> LayDanhSachDatPhong()
        {
            return danhSachDatPhong;
        }

        public DatPhong TimDatPhongTheoPhongVaThoiGian(int maPhong, DateTime ngayNhan, DateTime ngayTra)
        {
            foreach (DatPhong datPhong in danhSachDatPhong)
            {
                if (datPhong.MaPhong == maPhong && datPhong.NgayNhan == ngayNhan && datPhong.NgayTra == ngayTra)
                {
                    return datPhong;
                }
            }
            return null;
        }

        // Kiểm tra xem phòng đã được đặt trong khoảng thời gian đó chưa
        public bool KiemTraPhongTrongThoiGian(int maPhong, DateTime ngayNhan, DateTime ngayTra)
        {
            foreach (DatPhong datPhong in danhSachDatPhong)
            {
                if (datPhong.MaPhong == maPhong && !(datPhong.NgayTra <= ngayNhan || datPhong.NgayNhan >= ngayTra))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
