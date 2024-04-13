using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14. IndexOf
            string chuoi20 = "123asdfgad";
            int kq4 = chuoi20.IndexOf('a'); // tìm vị trí của index có chứa 'a' đầu tiên trong chuỗi
            Console.WriteLine(kq4);
            Console.WriteLine(chuoi20.Length);
            //15. LastIndexOf
            string chuoi21 = "1vacthangthien";
            int kq5 = chuoi21.LastIndexOf('a'); // tìm vị trí cuối cùng của index có chứa 'a' đầu tiên trong chuỗi
            Console.WriteLine(kq5);
            //16. Remove (xóa)
            string chuoi22 = "anhnhoemvl";
            chuoi22 = chuoi22.Remove(3, 3); // xóa từ vị trí index thứ 3 và xóa 3 phần tử kq sẽ là "anhemvl"
            Console.WriteLine(chuoi22);
            //17. Replace ("str out","str new")
            string chuoi23 = "iwillalwaysloveyouandyou";
            chuoi23 = chuoi23.Replace("you", "her");
            Console.WriteLine(chuoi23);
            //18. bool StarsWith
            string chuoi24 = "iwillalwaysloveyouandyou";
            bool check1 = chuoi24.StartsWith("iwill");
            Console.WriteLine(check1);
            //19. Substring (trích lọc chuỗi con từ chuỗi ban đầu)
            string chuoi25 = "dusaodinuaanhvanyeuem";
            string chuoi26 = chuoi25.Substring(10, 11); // từ vị trí index 10 lấy 11 ký tự của chuỗi 25 gán vào chuỗi 26 chuoi26 = "anhvanyeuem"
            Console.WriteLine(chuoi26);
            //20 Trả về chữ thường hoặc chữ hoa
            string chuoi27 = "SkSjHsJi";
            string chuoi28 = "RiIYYjK";
            chuoi27 = chuoi27.ToLower(); // trả chuoi27 về chữ thường hết
            chuoi28 = chuoi28.ToUpper(); // trả chuoi28 về chữ hoa hết
            Console.WriteLine(chuoi27);
            Console.WriteLine(chuoi28);
            //21 Trim xóa toàn bộ khoảng trắng ở đầu và ở cuối của chuỗi
            string chuoi29 = "     asd     ";
            chuoi29 = chuoi29.Trim(); // kết quả sẽ là chuoi29 = "asd" 
            Console.WriteLine(chuoi29);
            //22 TrimEnd chỉ xóa khoảng trắng ở cuối, TrimStart chỉ xóa khoảng trắng ở đầu
            string chuoi30 = "   asd   ";
            string chuoi31 = "   abc   ";
            chuoi30 = chuoi30.TrimEnd();
            chuoi31 = chuoi31.TrimStart();
            Console.WriteLine(chuoi30);
            Console.WriteLine(chuoi31);
            //23 Split tách chuỗi về mảng theo dấu
            string chuoi32 = @"D:\phambaokien\mariapikachu\trotyeu.mp3";
            string[] list = chuoi32.Split('\\');
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);
            Console.WriteLine(list[3]);
            //24 joint string nối các phần tử của 1 list thành 1 chuỗi
            string[] list24 = new string[3];
            list24[0] = "one";
            list24[1] = "two";
            list24[2] = "three";
            string chuoi33 = string.Join(",", list24); // tạo 1 chuỗi, nối các index trong list24 bằng dấu ,
            Console.WriteLine(chuoi33);
            Console.ReadKey();
        }
    }
}
