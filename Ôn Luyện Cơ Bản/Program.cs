using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Luyện_Cơ_Bản
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

                  
            for (int i = 10; i >0; i--)
            {
              for(int j = 0; j < 10; j++)
                {
                    if (j >= i) { Console.Write("*"); }
                    else { Console.Write(" "); }
                }




                Console.WriteLine();
                  
            }
            Console.ReadKey();
        }
    }
}
           



            
        
    

