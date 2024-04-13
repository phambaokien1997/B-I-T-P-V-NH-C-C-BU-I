using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            //1. Khai Báo chuỗi
            string chuoi = "Phạm Bảo Kiên";
            Console.WriteLine("Chuỗi bạn vừa nhập là: "+chuoi);
            //2. Khai báo nguyên văn
            string chuoi2 = @"D:\phambaokien";
            string chuoi3 = "Có người nói rằng \"không có gì là quan trọng hơn cái chết\"";
            Console.WriteLine(chuoi2);
            Console.WriteLine(chuoi3);
            //3. Chuyển đổi chuỗi
            int i = 12345;
            Console.WriteLine(i);
            Console.WriteLine(i.GetType().ToString());
            string chuoi5 = i.ToString(); // cách 1 chuyển đổi i sang chuỗi
            Console.WriteLine(chuoi5);
            Console.WriteLine(chuoi5.GetType().ToString());
            int i2 = 123456;
            string chuoi6 = i2 + ""; // cách 2
            Console.WriteLine(chuoi6);
            int i3 = 1234567;
            string chuoi7 = Convert.ToString(i3);
            Console.WriteLine(chuoi7);
            //4. tách chuỗi ra thành các ký tự lẻ và cho vào 1 mảng
            string chuoi8 = "XinChao";
            char[] list = chuoi8.ToCharArray();
            Console.WriteLine(list);
            Console.WriteLine(list.GetType().ToString());
            //5 Length
            string chuoi9 = "Test haha";
            int j = chuoi9.Length;
            Console.WriteLine(j);
            Console.WriteLine("Ký tự thứ 2 của chuỗi là : " + chuoi9[1]);
            Console.WriteLine("Ký tự cuối cùng của chuỗi là : " + chuoi9[j-1]);
            /*
             * 
             * 
             * VÍ DỤ
             * 
             * 
             */
            string chuoii = "Tôi là number 1";
            int chuHoa = 0;
            int chuThuong = 0;
            int chuSo = 0;
            int space = 0;
            char[] lst = chuoii.ToCharArray();
            foreach (char c in lst)
            {
                //Console.WriteLine(c);
                if (c == ' ')
                {
                    space++;
                }
                else if (char.IsDigit(c))
                {
                    chuSo++;
                }
                else if (char.IsLower(c))
                {
                    chuThuong++;
                }
                else if (char.IsUpper(c))
                {
                    chuHoa++;
                }    
            }
            Console.WriteLine("Trong chuỗi trên có : {0} chữ hoa, {1} chữ thường, {2} số và {3} khoảng trắng.", chuHoa, chuThuong, chuSo, space);
            //7. so sánh chuỗi
            string chuoi10 = "123456a";
            string chuoi11 = "123456o";
            int soSanh = chuoi10.CompareTo(chuoi11);
            Console.WriteLine(soSanh); // lớn hơn thì trả về 1 nhỏ hơn về -1 0 thì bằng nhau
            //8. Kiểm tra chuỗi con
            string chuoi12 = "abc";
            string chuoi13 = "assdfgabcsl123";
            bool l = chuoi13.Contains(chuoi12);
            Console.WriteLine(l);
            //9. Hàm Copyto
            string chuoi14 = "123456";
            char[] lst2 = new char[6]; // tạo ra một mảng có độ dài 6
            lst2[0] = 'a';
            lst2[1] = 'b';
            Console.WriteLine(lst2);
            chuoi14.CopyTo(1, lst2,2,4); //1: từ vị trí thứ 2 của chuỗi 14, lst2 : đến lst2, 2: vị trí thứ 3 của lst2, 4: 4 ký tự từ index 1 của chuoi14 (từ vị trí thứ 2 của chuoi14).
            Console.WriteLine(lst2);
            //10. Hàm EndsWith(string value)
            string chuoi15 = "ditimtinhyeu.mp3";
            bool kt = chuoi15.EndsWith("mp3"); // kiểm tra chuỗi 15 có phải kết thúc là mp3 không.
            //11. Gán chuỗi theo string.Format
            int n = 14;
            string chuoi16 = string.Format("n={0} và căn bậc 2 của n là {1}", n, Math.Sqrt(n));
            Console.WriteLine(chuoi16);
            Console.WriteLine("n={0} và căn bậc 2 của n là {1}", n, Math.Sqrt(n)); // chỉ xuất cho người dùng xem
            //12 bool Equals
            string chuoi17 = "haha";
            string chuoi18 = "haha";
            bool kt2 = chuoi17.Equals(chuoi18);
            //13 chèn thêm vào chuỗi string.Insert(<vị trí start_index chuỗi ban đầu>, <chuỗi cần chèn>)
            string chuoi19 = "123";
            string chuoi20 = "Fabaki";
            chuoi19 = chuoi19.Insert(1, chuoi20);// kết quả là 1Fabaki23...
            Console.WriteLine(chuoi19);
            Console.ReadKey();
        }
    }
}
