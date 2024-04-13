using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP3_Kế_thừa_Kế_thừa_thuộc_tính_Kế_thừa_phương_thức
{
    public class NhanVien
    {
        //khởi tạo
        public int maNV { get; set; }
        public string tenNV { get; set; }
        //phương thức tính lương nhân viên
        public double TinhLuong()
        {
            return 1000; //Lương cơ bản 1 tháng là 1000
        }
        //hàm ảo  virtual
        public virtual double ThuongDuCong(int ngayCong)
        {
            if (ngayCong >= 26)
            {
                return 100;
            }
            else
            {
                return 0;
            }
        }
    }
}
