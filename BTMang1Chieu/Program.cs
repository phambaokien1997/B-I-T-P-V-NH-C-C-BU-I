using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMang1Chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số phần tử trong mảng:");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");
            }
            Console.WriteLine();
            // nhập sô ngẫu nhiên
            //Random r = new Random();
            for(int i = 0;i < n; i++)
            {
                Console.WriteLine("Nhập phần tử thứ {0}", i + 1);
                int z = int.Parse(Console.ReadLine());
                mang[i] = z;
            }
            //xuất mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");
            }
            //Đảo ngược mảng 
            Array.Reverse(mang);
            //Sắp xếp tăng dần
            Array.Sort(mang);
            //Tính tổng
            int sum = 0;
            foreach(int i in mang)
            {
                sum += i;
            }
            Console.WriteLine("Tổng của các phần tử trong mảng là : "+sum);
            // Tồn tại
            Console.WriteLine("Nhập vào đây một số bất kì: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (mang[i] == x)
                {
                    Console.WriteLine("Số {0} tồn tại trong mảng và ở vị trí {1}", x , i);
                }    
            }
            Console.ReadKey();
        }
    }
}
