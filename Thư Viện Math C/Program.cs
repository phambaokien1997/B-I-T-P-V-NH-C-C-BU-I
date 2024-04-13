using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thư_Viện_Math_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            //Math.PI
            Console.WriteLine("Pi =" + Math.PI);
            Console.WriteLine("Kiểu dữ liệu của Math.PI là:" + Math.PI.GetType().ToString());
            float pi = (float)Math.PI;
            Console.WriteLine("Pi ="+pi);
            //Căn bậc 2
            int a = 4;
            int b = 10;
            Console.WriteLine("Căn bậc 2 của số a là :" + Math.Sqrt(a));
            Console.WriteLine("Kiểu dữ liệu của Marth.Sqrt() là :"+ Math.Sqrt(a).GetType().ToString());
            //Lũy thưa
            Console.WriteLine("2 lũy thừa 3 =" + Math.Pow(2,3));
            //Max min
            Console.WriteLine("Max =" +Math.Max(2,3));
            Console.WriteLine("Min =" +Math.Min(a,b));
            //Làm tròn
            float c = 1.23456789f;
            Console.WriteLine("Số c sau khi làm tròn đến 2 chữ số là:" + Math.Round(c,2));
            // Sin cos
            //Nhân với π/180
            //Từ đó, những gì bạn cần làm là lấy số độ bạn muốn tính cos sin nhân với π/180 để chuyển sang radian
            Console.WriteLine("Sin 30 là: " + Math.Sin(Math.PI*30/180));
            Console.ReadKey();
        }
    }
}
