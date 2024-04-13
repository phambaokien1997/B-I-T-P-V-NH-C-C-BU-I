using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 Khai báo biến
            char ch1 = 'a'; //khai báo bắt buộc dùng nháy đơn( và chỉ nhập 1 ký tự - aa thì k được)
            Console.WriteLine(ch1);
            Console.WriteLine("Kiểu dữ liệu của ch1 = " + ch1.GetType().ToString());
            // cách 2 
            char ch2 = (char)64; // tương ứng với ký tự @, 65 sẽ là A
            Console.WriteLine(ch2);
            Console.WriteLine("Kiểu dữ liệu của ch2 = " + ch2.GetType().ToString());
            //Ép kiểu char cho dữ liệu nhập vào
            char ch3 = char.Parse("b"); // chỉ ép kiểu cho 1 ký tự thôi
            Console.WriteLine(ch3);
            Console.WriteLine("Kiểu dữ liệu của ch3 = " + ch3.GetType().ToString());
            //Chuyển đổi kiểu dữ liệu
            char ch4 = Convert.ToChar("t");
            Console.WriteLine(ch4);
            Console.WriteLine("Kiểu dữ liệu của ch3 = " + ch4.GetType().ToString());
            //So sánh 2 ký tự dùng CompareTo
            char ch7 = 'a'; //97
            char ch8 = 'b'; //98
            char ch9 = 'a'; //97
            char ch10 = 'm'; //109
            Console.WriteLine(ch7.CompareTo(ch8));
            Console.WriteLine(ch8.CompareTo(ch7));
            Console.WriteLine(ch7.CompareTo(ch9));
            Console.WriteLine(ch9.CompareTo(ch7));
            Console.WriteLine(ch7.CompareTo(ch10));
            //So sánh 2 ký tự dùng Equals => trả về True, False
            Console.WriteLine(ch7.Equals(ch8)); //Falee
            Console.WriteLine(ch7.Equals(ch9)); //True
            //Các phương thức - Char Method trong C#
            Console.WriteLine(Char.IsDigit('a')); // kiểm tra chữ số trả về false nếu là số thì là true
            Console.WriteLine(Char.IsLetter('a'));// true kiểm tra chữ cái
            Console.WriteLine(Char.IsWhiteSpace(' '));// true
            Console.WriteLine(Char.IsLower('a')); // true
            Console.WriteLine(Char.IsLower('A')); // true
            Console.WriteLine(Char.ToUpper('a')); //Chuyển a nhỏ sang A lớn (in hoa)
            Console.WriteLine(Char.ToLower('A')); //Chuyển A sang a (in lại thường)
            Console.ReadKey();

        }
    }
}
