using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ListG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Khởi tạo danh sách
            List<string> danhSach = new List<string>();
            List<int> danhSach2 = new List<int>();
            //3. khởi tạo danh sách {}
            List<int> danhSach3 = new List<int>() { 1, 2, 3, 5, 6, 8 };
            foreach (int i in danhSach3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //4. Phương Thức thêm
            List<int> danhSach4 = new List<int>() { 1, 2, 3, 4, 5 };
            danhSach4.Add(100); // thêm vào cuối danh sách
            foreach (int i in danhSach4)
            {
                Console.Write(i + " ");
            }


            //5.Remove
            danhSach4.Remove(2); // xóa phần tử đầu tiên nếu tìm thấy trong ds
            //6.Count
            danhSach4.Count(); // đếm số phần tử trong danh sách    
            //7. Clear xóa toàn bộ phần tử
            //8.AddRange 
            List<int> ds8 = new List<int>() { 1, 2, 3 };
            List<int> ds9 = new List<int>() { 4, 5 };
            ds8.AddRange(ds9);
            foreach (int i in ds8)
            {
                Console.Write(i + " ");
            }
            //9. bool kq check có phần tử trong list không
            List<int> ds10 = new List<int>() { 4, 5 };
            bool kq = ds10.Contains(15);
            Console.WriteLine(kq);
            //10. GetRanged trả về 1 list con 
            List<int> ds11 = new List<int>() { 1, 5, 8, 9, 7 };
            List<int> ds12 = ds11.GetRange(1, 3); // lấy từ index 1 và lấy 3 phần tử.
            //11. IndexOf trả về vị trí index tìm thấy nếu không tìm thấy thì trả về -1
            List<int> ds13 = new List<int>() { 1, 2, 3 };
            int checkInDex = ds13.IndexOf(3); // = 2;
            Console.WriteLine(checkInDex);
            //12. Insert ( int index , value)
            List<int> ds14 = new List<int>() { 1, 2, 6, 7 };
            ds14.Insert(2, 4);
            foreach (int i in ds14)
            {
                Console.Write(i + " ");
            }
            //13. InsertRanged (int index, danh sách chèn)
            List<int> ds15 = new List<int>() { 12, 4, 123, 5, 2 };
            List<int> ds16 = new List<int>() { 1, 2 };
            ds16.InsertRange(1, ds15);
            foreach (int i in ds16)
            {
                Console.Write(i + " ");
            }
            //14. Removeat
            List<int> ds17 = new List<int>() { 12, 4, 123, 5, 2 };
            ds17.RemoveAt(2);// xóa 123
            //15. RemoveRange (int index, int count)
            List<int> ds18 = new List<int>() { 12, 4, 123, 5, 2 };
            ds18.RemoveRange(1, 2); /*ds18: {12 ,5 ,2}*/
            //16 . ds đảo ngược 
            List<int> ds19 = new List<int>() { 12, 4, 123, 5, 2 };
            ds19.Reverse();
            //17. ds tăng dần
            List<int> ds20 = new List<int>() { 12, 4, 123, 5, 2 };
            ds20.Sort();
            Console.WriteLine();
            //ds20.Reverse();
            //18. BinarySearch tìm kiếm nhị phân. chỉ dùng sau khi đã sắp xếp mảng
            int kq2 = ds20.BinarySearch(123);
            Console.WriteLine(kq2);
            //19. Max Min
            int kMax = ds20.Max();
            int kMin = ds20.Min();
            Console.WriteLine("Max = {0}, min = {1}.",kMax,kMin);


            Console.ReadKey();






        }
    }
}
