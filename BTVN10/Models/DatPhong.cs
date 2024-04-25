using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Models
{
    public class DatPhong : KhachHang
    {
        // Thuộc tính của lớp DatPhong
        public int MaDatPhong { get; set; } // Thuộc tính chỉ đọc, không có setter
        //public int MaKhachHang { get; set; }
        public int MaPhong { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime NgayNhan { get; set; }
        public DateTime NgayTra { get; set; }

        // Constructor không tham số
        public DatPhong()
        {
        }

        // Constructor với tham số
        public DatPhong(int maDatPhong, int maKhachHang, int maPhong, DateTime ngayDat, DateTime ngayNhan, DateTime ngayTra)
        {
            MaDatPhong = maDatPhong; // Khởi tạo giá trị cho MaDatPhong trong constructor
            MaKhachHang = maKhachHang;
            MaPhong = maPhong;
            NgayDat = ngayDat;
            NgayNhan = ngayNhan;
            NgayTra = ngayTra;
        }
        public DatPhong(int maPhong, int maKhachHang, DateTime ngayDat, DateTime ngayNhan, DateTime ngayTra)
        {
            MaKhachHang = maKhachHang;
            MaPhong = maPhong;
            NgayDat = ngayDat;
            NgayNhan = ngayNhan;
            NgayTra = ngayTra;
        }

        // Phương thức để hiển thị thông tin đặt phòng
        public override string ToString()
        {
            return $"Mã đặt phòng: {MaDatPhong}, Mã khách hàng: {MaKhachHang}, Mã phòng: {MaPhong}, Ngày đặt: {NgayDat}, Ngày nhận: {NgayNhan}, Ngày trả: {NgayTra}";
        }
    }
}
