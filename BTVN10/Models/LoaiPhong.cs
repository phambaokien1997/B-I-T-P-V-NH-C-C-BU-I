using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN10.Models
{
    public class LoaiPhong
    {
        public int MaLoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }

        public LoaiPhong()
        {
           
        }

        public LoaiPhong(int maLoaiPhong, string tenLoaiPhong)
        {
            MaLoaiPhong = maLoaiPhong;
            TenLoaiPhong = tenLoaiPhong;
            
        }

        public override string ToString()
        {
            return $"Mã loại phòng: {MaLoaiPhong}, Tên loại phòng: {TenLoaiPhong}";
        }
    }
}
