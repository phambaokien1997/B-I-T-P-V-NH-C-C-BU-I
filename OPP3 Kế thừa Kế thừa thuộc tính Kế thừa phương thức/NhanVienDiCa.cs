using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP3_Kế_thừa_Kế_thừa_thuộc_tính_Kế_thừa_phương_thức
{
    public class NhanVienDiCa:NhanVien
    {
        //Khai báo thêm các thuộc tính ca ngày, ca đêm
        public string Ca {  get; set; }
        //Phương thức tính lương của nhân viên di ca
        public new double TinhLuong()
        {
            return base.TinhLuong()*1.15;
        }
    }
}
