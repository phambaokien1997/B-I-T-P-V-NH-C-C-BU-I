using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Models
{
    public class Phong
    {
        // Thuộc tính của lớp Phong
        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public LoaiPhong LoaiPhong { get; set; }
        public decimal GiaPhong { get; set; }
        
        public bool TrangThai { get; set; } // Trạng thái phòng: true - đang sử dụng, false - không sử dụng

        // Constructor không tham số
        public Phong()
        {
        }

        // Constructor với tham số
        public Phong(int maPhong, string tenPhong, LoaiPhong loaiPhong, decimal giaPhong, bool trangThai)
        {
            MaPhong = maPhong;
            TenPhong = tenPhong;
            LoaiPhong = loaiPhong;
            GiaPhong = giaPhong;
            TrangThai = trangThai;
        }

        // Phương thức để hiển thị thông tin của phòng
        public override string ToString()
        {
            return $"Mã phòng: {MaPhong}, Tên phòng: {TenPhong}, Loại phòng: {LoaiPhong}, Giá phòng: {GiaPhong}, Trạng thái: {(TrangThai ? "Đang sử dụng" : "Không sử dụng")}";
        }
    }
}
