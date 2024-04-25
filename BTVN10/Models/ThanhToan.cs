using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Models
{
    public class ThanhToan : DatPhong
    {
        public int MaHoaDon {  get; set; }
        
        public decimal TongTien { get; set; }


        public ThanhToan()
        {

        }
        public ThanhToan(int maHoaDon, int maDatPhong, int maKhachHang, int maPhong ,DateTime ngayDat, DateTime ngayTra)
        {
            MaHoaDon = maHoaDon;
            MaDatPhong = maDatPhong;
            MaKhachHang = maKhachHang;
            MaPhong = maPhong;
            NgayDat = ngayDat;
            NgayTra = ngayTra;
        }
        public override string ToString()
        {
            return $"Mã hóa đơn: {MaHoaDon}, Mã đặt phòng: {MaDatPhong},Mã khách hàng: {MaKhachHang},Mã phòng: {MaPhong} Tổng tiền: {TongTien}, Ngày thanh toán: {NgayTra}";
        }
    }
}
