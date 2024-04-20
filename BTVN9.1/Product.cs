using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BTVN9._1
{
   
    public class Product
    {
        public string Ten { get; set; }

        public double Gia { get; set; }
        public Loaichietkhau Loaichietkhau { get; set; }
        public double GiaTriChietKhau { get; set; }
        public double GiaSauKhiChietKhau {  get; set; }
        public double TinhChietKhau()
        {
            switch (Loaichietkhau)
            {
                case Loaichietkhau.TheoSoTien:
                    if (Gia > GiaTriChietKhau)
                    {
                        return GiaTriChietKhau;
                    }
                    else
                    {
                        return 0;
                    }
                case Loaichietkhau.TheoPhanTram:
                    return Gia * GiaTriChietKhau / 100;
                default : return 0;
            }
        }
    }
    public enum Loaichietkhau
    {
        TheoSoTien,
        TheoPhanTram
    }

    
}
