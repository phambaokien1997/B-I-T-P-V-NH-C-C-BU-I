using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN6
{
    public class GenericClass<T>
    {
        private List<T> baoKienList;

        public GenericClass()
        {
            baoKienList = new List<T>();
        }

        public void AddItems(T item)
        {
            baoKienList.Add(item);
        }

        public void RemoveItems(T item)
        {
            baoKienList.Remove(item);
        }

        public void DisplayItems()
        {
            foreach (var item in baoKienList)
            {
                Console.WriteLine(item);
            }
        }

        public bool SearchItems(T item)
        {
            return baoKienList.Contains(item);
        }
    }

    public class SinhVien
    {
        public int MaSV { get; set; }
        public string TenSV { get; set; }

        public SinhVien(int maSV, string tenSV)
        {
            MaSV = maSV;
            TenSV = tenSV;
        }

        public override string ToString()
        {
            return $"Mã Sinh Viên: {MaSV}, Tên Sinh Viên: {TenSV}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            SinhVien other = (SinhVien)obj;
            return MaSV == other.MaSV || TenSV==other.TenSV;
            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            GenericClass<SinhVien> danhSachSV = new GenericClass<SinhVien>();
            danhSachSV.AddItems(new SinhVien(1, "Phạm Bảo Kiên"));
            danhSachSV.AddItems(new SinhVien(2, "Phạm Bảo Khiêm"));
            danhSachSV.AddItems(new SinhVien(3, "Đỗ Đức Uy"));

            Console.WriteLine("Danh sách sinh viên:");
            danhSachSV.DisplayItems();

            Console.WriteLine("\nSinh viên có mã sinh viên là 2:");
            SinhVien timKiemSV = new SinhVien(2, "");
            Console.WriteLine(danhSachSV.SearchItems(timKiemSV) ? "Đã Thấy" : "Không Tìm Thấy");
            Console.WriteLine("\nSinh viên có tên sinh viên là Đỗ Đức Uy:");
            SinhVien timKiemSVp = new SinhVien(10, "Đỗ Đức Uy");
            Console.WriteLine(danhSachSV.SearchItems(timKiemSVp) ? "Đã Thấy" : "Không Tìm Thấy");

            Console.WriteLine("\nXóa sinh viên có mã sinh viên là 2!!");
            danhSachSV.RemoveItems(timKiemSV);
            Console.WriteLine("\nXóa sinh viên có tên là Đỗ Đức Uy!!");
            danhSachSV.RemoveItems(timKiemSVp);
            Console.WriteLine("\nDanh sách sinh viên sau khi xóa:");
            danhSachSV.DisplayItems();
            Console.ReadKey();
        }
    }
}
