using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN6._2
{
    public class QuanLySinhVien
    {
        private Dictionary<int, string> SinhVien;

        public QuanLySinhVien()
        {
            SinhVien = new Dictionary<int, string>();
        }

        public void AddItems(int maSV, string tenSV)
        {
            SinhVien.Add(maSV, tenSV);
        }

        public string GetItems(int maSV)
        {
            return SinhVien.ContainsKey(maSV) ? SinhVien[maSV] : null;
        }
        public string GetItems2(string tenSV)
        {
            foreach (var pair in SinhVien)
            {
                if (pair.Value == tenSV)
                {
                    return pair.Key.ToString();
                }
            }
            return null;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            QuanLySinhVien qlsv = new QuanLySinhVien();
            qlsv.AddItems(1, "Phạm Bảo Kiên");
            qlsv.AddItems(2, "Phạm Bảo Khiêm");
            qlsv.AddItems(3, "Đỗ Đức Uy");
            Console.WriteLine(qlsv);
            Console.WriteLine("Sinh viên có mã sinh viên là 2 là:");
            Console.WriteLine(qlsv.GetItems(2));
            Console.WriteLine("Sinh viên có tên Phạm Bảo Kiên có mã là:");
            Console.WriteLine(qlsv.GetItems2("Phạm Bảo Kiên"));


            Console.ReadKey();
        }
    }
}
