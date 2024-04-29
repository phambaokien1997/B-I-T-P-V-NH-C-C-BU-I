
using System;
using SPHO.service;

namespace SPHO
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = new LibraryFileReader();
                var b = a.GetBooks("thu vien hue");
                if ()
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
    

   public class HoSoHuongNghiep<T1,T2>
    {

        public T1 Carrier { get; set; }
        public  T2 Toan { get; set; }
        public T2 Van { get; set; }
        public T2 Anh { get; set; }
    }
    public class NghiepNghiep
    {

    }
    public class CongAn : NghiepNghiep
    {
        public string DonVi { get; set; }
        public string QuanHam { get; set; }
    }

    public class Programmer : NghiepNghiep
    {
        public string Cty { get; set; }
        public string NgonNgu { get; set; }
        public string IsFullstack { get; set; }
    }
}
