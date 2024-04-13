using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# 19
            Console.OutputEncoding = Encoding.UTF8;
            int Sum = 0;
            string strSo = "";
            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            string[] list = str1.Split(' ');
            foreach (string l in list)
            {
                //Console.WriteLine(l);
                foreach (char l2 in l)
                {
                    //Console.WriteLine(l2);
                    if (char.IsDigit(l2))
                    {
                        strSo += l + " ";
                        break;
                    }
                }
            }
            Console.WriteLine(strSo);
            strSo = strSo.TrimEnd();
            Console.WriteLine(strSo);
            string[] list2 = strSo.Split(' ');
            foreach (string l2 in list2)
            {
                Sum += int.Parse(l2);
            }
            Console.WriteLine("Tổng các số cần tìm là: " + Sum);
            //Console.ReadKey();
            //C# 20
            bool gg = false;
            do
            {
                Console.WriteLine("Nhập vào đây để tạo 1 mật khẩu:");
                string mk = Console.ReadLine();
                int soSo = 0;
                int chu = 0;
                char[] kt = mk.ToCharArray();
                foreach (char k in kt)
                {
                    if (char.IsDigit(k))
                    {
                        soSo++;
                    }
                    else if (char.IsLetter(k))
                    {
                        chu++;
                    }
                }

                Console.WriteLine("mk = " + mk);
                if (mk.Length >= 6 && soSo >= 1 && chu >= 1)
                {
                    Console.WriteLine("Mật khẩu hợp lệ.");
                    gg = true;


                
                //else
                //{
                //    Console.WriteLine("Mật khẩu không hợp lệ");
                //}


                bool check = false;
                int soLanNhapSai = 0;
                do
                {

                    Console.WriteLine("Nhập vào đây mật khẩu đi thím ơi:");
                    string nhap = Console.ReadLine();
                    if (nhap.Equals(mk))
                    {
                        Console.WriteLine("Bạn đã đăng nhập thành công!");
                        check = true;
                        break;
                    }
                    soLanNhapSai++;
                    if (soLanNhapSai == 6)
                    {
                        Console.WriteLine("Bạn đã nhập sai quá 5 lần. Hãy chạy lại chương trình");
                        break;
                    }
                }
                while (!check);
                }
            }
            while (!gg);


            //C# 21
            string a = "abcsjdfkh";
            string b = "xyzdjkhke";
            string c = "";
            Console.WriteLine("Mời bạn nhập vào chuỗi cần mã hóa");
            string doanNhap = Console.ReadLine();
            foreach(char d in doanNhap)
            {
                int indexKytu = a.IndexOf(d);
                //Console.WriteLine(b[indexKytu]);
                c += b[indexKytu];
            }
            Console.WriteLine("Chuỗi sau khi mã hóa là: "+c);


            Console.ReadKey();



        }
    }
}
