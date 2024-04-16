using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mảng_2_chiều
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            //1. Mảng 2 chiều
            //Khai báo
            int[,] arr = new int[3, 5]; // 3 hàng 5 cột
            //2. khởi tạo và gán 
            int[,] arr2 = new int[2, 3] { { 1, 2, 3 }, { 8, 5, 4 } };

            //3. Nhập giá trị ngẫu nhiên cho mảng dùng 2 vòng for
            Random r = new Random();
            int dong = 3;
            int cot = 4;
            int[,] arr3 = new int[dong, cot];
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    //Console.Write(i);
                    //Console.Write(j+"\t");
                    arr3[i, j] = r.Next(51);
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine(arr3[0, 0]);
            Console.WriteLine(arr3[0, 1]);
            //xuất mảng
            Console.WriteLine("Ma trận ngẫu nhiên vừa tạo ra là :");
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for(int j = 0;j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i,j] + "\t");
                }
                Console.WriteLine();
            }
            //
            Console.ReadKey();

        }
    }
}
