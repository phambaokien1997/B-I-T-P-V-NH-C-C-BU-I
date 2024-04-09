using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Luyện_Cơ_Bản
{

    internal class Concho
    {
        public string MauLong {get; set ;}
        public int Tuoi { get; set ;}
        
        public void Eat()
        {
            Console.WriteLine("Đang ăn rất ngon");
        }
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //Concho concho1 = new Concho();
            //concho1.MauLong = "Màu Vàng";
            //concho1.Tuoi = 3;
            //concho1.Eat();
            
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

            //float quangDuong;
            //float h;
            //float m;
            //float s;
            //float tongTime;
            //float ms;
            //float kh;
            //Console.WriteLine("Nhập quãng đường");
            //quangDuong = float.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập giờ:");
            //h = float.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập phút:");
            //m = float.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập giây:");
            //s = float.Parse(Console.ReadLine());
            //tongTime = h * 3600 + m * 60 + s;
            //ms = quangDuong / tongTime;
            //kh = (quangDuong/1000f) /(h+(m/60f)+(s/3600f));
            //Console.WriteLine("Vận tốc m/s:" + ms);
            //Console.WriteLine("Vận tốc km/h:" + kh);
            //int H, K, T;
            //H = K = T = 10;
            //H += K = T = 5;
            //Console.WriteLine( H +","+ K +","+ T);

            //object obj = "PhamBaoKien";
            ////boxing chuyển kiểu dữ liệu từ kiểu giá trị dữ liệu sang kiểu dữ liệu tham chiếu
            //int value = 1000;
            //object objectValue = value;

            //int newValue = (int)objectValue;

            //var varInt = 11;
            //var varBool = true;
            //var varString = "FaBaKi";
            //string header = "FaBaKihandsome";
            //Console.WriteLine(varString);
            //Console.WriteLine(header);

            //dynamic StringValue = "Fabaki";
            ////dynamic khi chạy chương trình mời báo lỗi;
            //object stringvl = "Fbaki";
            ////StringValue++;

            //string vl2 = "thieulamquyen";
            //string vl3 = "voanhcuoc";

            //dynamic volam2 = vl2;
            //Console.WriteLine(volam2 + " da " + vl3);

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Kien dep trai");
            //}
            //    string BK = "Fabaki";
            //    int count = 0;
            //beginLoop:
            //    Console.WriteLine(BK);
            //    count++;
            //    if (count < 10)
            //        goto beginLoop;
            //for(/*Khởi tạo*/; /* Điều kiện lặp*/;/*bước lặp*/ )
            //    {

            //    }  
            //for(int i =0; i<10 ;i++ )
            //    {
            //        Console.WriteLine(i) ;
            //    }    
            //public static bool CheckXSSInput(string input)
            //{
            //    try
            //    {
            //        var listdangerousString = new List<string> { "<applet", "<body", "<embed", "<frame", "<script", "<frameset", "<html", "<iframe", "<img", "<style", "<layer", "<link", "<ilayer", "<meta", "<object", "<h", "<input", "<a", "&lt", "&gt" };
            //        if (string.IsNullOrEmpty(input)) return false;
            //        foreach (var dangerous in listdangerousString)
            //        {
            //            if (input.Trim().ToLower().IndexOf(dangerous) >= 0) return false;
            //        }
            //        return true;
            //    }
            //    catch (Exception ex)
            //    {
            //        return false;
            //    }
            //}
            //Console.OutputEncoding=Encoding.UTF8;
            //int N = 10;
            //int M = 20;
            //char sao = '*';
            //char khoangTrong = ' ';
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0;j < M; j++)
            //    {
            //        if (i % (N - 1) == 0 || ((i % (N - 1) != 0) && (j % (M-1) == 0)))
            //        {
            //            Console.Write(sao);
            //        }
            //        else
            //        {
            //            Console.Write(khoangTrong);
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Demo();
            //}
            //int count = 0;
            //do
            //{
            //    Demo();
            //    count++;
            //}
            //while (count < 10);


            //int num1 = 3;
            //int num2 = 4;
            //for (int i = 0; i < 20; i++)
            //{
            //    PrintSumNumber(num1, num2);
            //}
            //Console.WriteLine(ReturnANumber());
            //Demo();
            //Console.WriteLine(SumNumber(15, 20));
            //PrintSomething("Phạm Bảo Kiên", 27);
            //string[] HoTenSinhVien = new string[3] {"Phạm Bảo Kiên","Phạm Bảo Khiêm","Hoàng Phạm Lệ Thương"};
            //for (int i = 0; i < HoTenSinhVien.Length; i++)
            //{
            //    HoTenSinhVien[i] = Console.ReadLine();
            //    //Console.WriteLine(HoTenSinhVien[i]);
            //}
            //for (int i = 0; i < HoTenSinhVien.Length; i++)
            //{

            //    Console.WriteLine(HoTenSinhVien[i]);
            //}
            //int[] a = { 1, 2, 5, 4, 3};
            //Array.Reverse(a);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(Array.IndexOf(a,5));

            Console.ReadKey();

       
        }
        //Hàm:
        //static void Demo()
        //{
        //    Console.WriteLine(ReturnANumber());
        //    Console.WriteLine("Phạm Bảo Kiên");
        //}
        //static int ReturnANumber()
        //{
        //    return 5;
        //}
        ////static int Number1 = 10;
        ////static int Number2 = 20;    
        //static int SumNumber(int Number1, int Number2)
        //{
        //    return Number1 + Number2;
        //}
        //static void PrintSumNumber(int Number1, int Number2)
        //{
        //    Console.WriteLine("{0}+{1}={2}", Number1, Number2, SumNumber(Number1, Number2));
        //}
        //static void PrintSomething(string name, int age)
        //{
        //    if (age == 1) 
        //    { 
        //        Console.WriteLine("Tôi là : {0}, năm nay tôi : {1} year old", name, age); 
        //    }
        //    else if (age <= 0)
        //    {
        //        Console.WriteLine("nhập tuổi không chính xác");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Tôi là : {0}, năm nay tôi : {1} years old", name, age);
        //    }

        //}
    }
}








