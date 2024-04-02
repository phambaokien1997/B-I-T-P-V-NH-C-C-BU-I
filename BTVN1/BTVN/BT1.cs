using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic;

public class Class1
{
    static void Main(string[] args)
    {
        float a;
        float b;
        float s;
        bool kq = true;
        do        {
         
            Console.WriteLine("Nhap a la chieu dai: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b la chieu rong:");
            b = float.Parse(Console.ReadLine());

            s = a * b;
            p = (a + b) * 2;
            kq = (a > 0 && b > 0);
            if (kq)
            {
                Console.WriteLine("dien tich  la: {0} , chu vi la : {1}", s, p);
                break;
            }

            else
            {
                Console.WriteLine("Nhap sai roi");
            }
        }
        while (kq = true);
        Console.Readkeu();
    }
}
