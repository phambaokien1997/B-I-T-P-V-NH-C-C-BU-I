using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mảng_1_chiều
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1. Khai báo mảng
            int[] stt;
            char[] ch;
            string[] ten;
            //2. Khởi tạo mảng
            stt = new int[5];
            Console.WriteLine("Mảng stt là : ");
            foreach (int i in stt)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Mảng số thứ tự 2 là :");
            int[] stt2 = new int[7];
            foreach(int i in stt2)
            {
                Console.Write(i + " ");
            }
            //3. Khởi tạo và gán luôn giá trị cho mảng
            Console.WriteLine();
            Console.WriteLine("Mảng 2 là: ");
            int[] mang2 = new int[3] { 1, 2, 3 };
            foreach(int i in mang2)
            {
                Console.Write(i + " ");
            }
            //6. Khởi tạo mảng và gán giá trị ngẫu nhiên cho mảng
            Console.WriteLine();
            Console.WriteLine("Mảng 3 là :");
            Random rd = new Random();
            int[] mang3 = new int[3] { rd.Next(50), rd.Next(50), rd.Next(50) };
            foreach (int i in mang3)
            {
                Console.Write(i + " ");
            }
            //7. Độ dài của mảng
            int[] mang4 = { 1, 2, 4, 5, 6 };
            Console.WriteLine();
            int doDai4 = mang4.Length;
            Console.WriteLine("Độ dài của mảng 4 là : " + doDai4);
            //8. Truy xuất phần tử qua index 
            Console.WriteLine();
            Console.WriteLine("Phần tử thứ 1 là:" + mang4[0]);
            //9. Thay đổi phần tử 
            Console.WriteLine();
            int[] mang5 = { 1, 3, 5, 9, 8 };
            mang5[0] = 10;
            foreach(int i in mang5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
            //10. Duyệt bằng for ( duyệt theo index)
            for (int j = 0; j < mang5.Length; j++)
            {
                Console.Write(j + " ");
                //Console.Write(mang5[j] + " ");
            }
            //12. Phép gán mảng
            int[] mang8 = { 1, 2, 3, 4, 5, 6 };
            int[] mang9 = mang8;
            mang8[0] = 100;
            Console.WriteLine(mang8[0]);
            Console.WriteLine(mang9[0]);
            //13. Copyto
            Console.WriteLine();
            
            int[] mang10 = { 10, 20, 30, 40, 50 };
            int[] mang11 = { 1, 2, 3, 4, 5, 6, 7 };
            mang10.CopyTo(mang11, 2);
            Console.WriteLine("Mảng 11 sau khi copy là: ");
            foreach (int i in mang11)
            {
                Console.Write(i + " ");
            }
            //14. Copy
            int[] mang12 = { 10, 20, 30, 40, 50 };
            int[] mang13 = new int[4];
            Array.Copy(mang12, mang13, 3);
            Console.WriteLine();
            Console.WriteLine("Mảng 13 là: ");
            foreach(int i in mang13) 
            {
                Console.Write(i + " ");
            }
            //15. Clone (Tạo ra một vùng nhớ mới) COPY tất cả các phần tử của mảng cũ sang mảng mới
            int[] mang14 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] mang15 = (int[])mang14.Clone();
            Console.WriteLine();
            Console.WriteLine("Mảng 15 là :");
            foreach(int i in mang15)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //16. Reverse
            int[] mang16 = { 1, 2, 3, 4, 5, 6, 4 };
            Array.Reverse(mang16);
            //17. Sort
            int[] mang17 = { 1, 3, 5, 4, 2, 2, 3, 1 };
            Array.Sort(mang17);

            Console.ReadKey();

        }
    }
}
