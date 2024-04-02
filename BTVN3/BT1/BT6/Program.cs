using System;
using System.ComponentModel.Design;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        bool check = true;
        do
        {
            int a;



            Console.WriteLine("Nhập vào đây số ngẫu nhiên từ 1-100: ");
            a = int.Parse(Console.ReadLine());
            Random rd = new Random();
            int soNgauNhien = rd.Next(1, 100);
            Console.WriteLine("Số bạn random ra là :" + soNgauNhien);
            if (a > 1 && a < 100)
            {

                if (a == soNgauNhien)
                {
                    Console.WriteLine("Số {0} bạn vừa nhập có giá trị bằng với số được random", a);
                }
                else if (a > soNgauNhien)
                {
                    Console.WriteLine("Số {0} bạn vừa nhập có giá trị lớn hơn số được random", a);
                }
                else if (a < soNgauNhien)
                {

                    Console.WriteLine("Số {0} bạn vừa nhập có giá trị nhỏ hơn số được random", a);
                }
                check=false; 

            }
            else Console.WriteLine("ban nhap sai roi");


        } while (check);





    }
}
