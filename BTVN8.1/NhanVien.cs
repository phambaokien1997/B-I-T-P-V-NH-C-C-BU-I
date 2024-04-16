using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN8._1
{
    class NhanVien
    {
        public string tenNV { get; set; }
        public NhanVien(string ten) 
        { 
            tenNV = ten; 
        }
        public virtual void xuatNV()
        {
            Console.WriteLine("Tên Nhân viên : " + tenNV);
        }
    }
}
