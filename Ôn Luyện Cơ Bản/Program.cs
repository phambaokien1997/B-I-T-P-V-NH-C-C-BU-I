using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Luyện_Cơ_Bản
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            //Console.OutputEncoding= Encoding.UTF8;
            //Console.WriteLine("Hello world");
            //int a = 1;int b = 2;
            //int sum = a + b;
            //Console.WriteLine("Sum =" +sum);
            //int tru = a - b;
            //int nhan = a * b;
            //int chia = a / b;
            //Console.WriteLine("Trừ=" + tru);
            //Console.WriteLine("Nhân=" + nhan);
            //Console.WriteLine("Chia=" +chia);

            //Console.WriteLine("Nhập độ C vào đây:");
            //int C = int.Parse(Console.ReadLine());
            //Console.WriteLine("Độ C tương ứng là {0}", C + 273);
            //Console.WriteLine("Độ F tương ứng là {0}", C*18/10 + 32);
            //Console.ReadKey();



            //Bài Tập Kiểu Dữ Liệu:


            //for (int i = 10; i >0; i--)
            //{
            //  for(int j = 0; j < 10; j++)
            //    {
            //        if (j >= i) { Console.Write("*"); }
            //        else { Console.Write(" "); }
            //    }




            //    Console.WriteLine();

            //}

            //int a;
            //int b;
            //do {
            //    Console.WriteLine("Nhập a:");
            //    a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Nhập b:");
            //    b = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Nhập phép toán bạn cần làm vào đây");
            //    char c = char.Parse(Console.ReadLine());
            //    if (c == '+')
            //    {
            //        Console.WriteLine("{0}{1}{2} = {3}", a, c, b, a + b);
            //        break;
            //    }
            //    else if (c == '-')
            //    {
            //        Console.WriteLine("{0}{1}{2} = {3}", a, c, b, a - b);
            //        break;
            //    }
            //    else if (c == '*')
            //    {
            //        Console.WriteLine("{0}{1}{2} = {3}", a, c, b, a * b);
            //        break;
            //    }
            //    else if (c == '/')
            //    {
            //        Console.WriteLine("{0}{1}{2} = {3}", a, c, b, a / b);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bạn nhập phép toán sai gòi ^^ nhập lại đê ");
            //    }
            //}
            //while (true);

            //const double Pi = 3.14;
            //double r;
            //double c;
            //double d;
            //Console.WriteLine("Nhập bán kính hình tròn vào đây đê:");
            //r = double.Parse(Console.ReadLine());
            //c = 2*r* Pi;
            //Console.WriteLine("Chu vi của hình tròn là:" + c);
            //d = r*r*Pi;
            //Console.WriteLine("Diện thích của hình tròn là:" + d);

            //int y;
            //int x;
            //for(y = -5; y <= 5; y++) 
            //{
            //    x = y * y - 2 * y + 1;
            //    Console.WriteLine("Với giá trị y = {0} thì x = {1}", y,x);
            //}

            float quangDuong;
            float h;
            float m;
            float s;
            float tongTime;
            float ms;
            float kh;
            Console.WriteLine("Nhập quãng đường");
            quangDuong = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giờ:");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập phút:");
            m = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giây:");
            s = float.Parse(Console.ReadLine());
            tongTime = h * 3600 + m * 60 + s;
            ms = quangDuong / tongTime;
            kh = (quangDuong/1000f) /(h+(m/60f)+(s/3600f));
            Console.WriteLine("Vận tốc m/s:" + ms);
            Console.WriteLine("Vận tốc km/h:" + kh);
            Console.ReadKey();
        }
    }
}
           



            
        
    

