using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //________________________RANDOM_____________________________//
            //cú pháp tạo ra 1 đối tượng để random 1 số ngẫu nhiên
            Random rd = new Random();
            //random 1 số ngẫu nhiên :
            int soNgauNhien = rd.Next(50, 101);// nằm ngẫu nhiên trong khoảng từ 50-100
            int soNgauNhien2 = rd.Next(101);// nằm ngẫu nhiên trong khoảng từ 0-100
            int soNgauNhien3 = rd.Next(1, 101);// nằm ngẫu nhiên trong khoảng từ 1-100
            Console.WriteLine("Số ngẫu nhiên máy sinh ra là: " + soNgauNhien);
            //Muốn lấy số ngẫu nhiên nằm trong đoạn (0,1) ( từ 0 đến sát 1)
            double k2 = rd.NextDouble();
            Console.WriteLine("Số ngẫu nhiên 2 là:" + k2);
            //1.2313123123
            double k3 = k2 + soNgauNhien3;
            Console.WriteLine("Giá trị ngẫu nhiên mong muốn là : " + k3); //cách này tối ưu hơn nhé
            //cách 2 :
            double k4 = k2 * 10;
            Console.WriteLine("Giá trị ngẫu nhiên 2 mong muốn là :" + k4);
            //________________________DATETIME_____________________________//
            DateTime birthDay = new DateTime(1997, 02, 04);
            Console.WriteLine("Ngày sinh của Phạm Bảo Kiên là:" + birthDay.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngày sinh của Phạm Bảo Kiên là:" + birthDay.ToString("dd"));
            Console.WriteLine("Tháng sinh của Phạm Bảo Kiên là:" + birthDay.ToString("MM"));
            Console.WriteLine("Năm sinh của Phạm Bảo Kiên là:" + birthDay.ToString("yyyy"));

            DateTime birthDay2 = DateTime.Parse("11/24/2000");
            Console.WriteLine("Ngày tháng năm sinh của bạn là:" +birthDay2.ToString("dd/MM/yyyy"));
            //Viết chương trình cho người dùng nhập vào ngày tháng năm sinh 
            Console.WriteLine("Mời bạn nhập vào ngày tháng năm sinh (tháng/ ngày/ năm): ");
            string s = Console.ReadLine();
            DateTime birthDay3 = DateTime.Parse(s);
            Console.WriteLine("Ngày sinh của bạn vừa nhập là: "+ birthDay3.ToString("dd/MM/yyyy"));

            Console.ReadKey();
        }
    }
}
