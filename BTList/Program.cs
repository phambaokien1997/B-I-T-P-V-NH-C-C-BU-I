using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            //C#24
            //Random r = new Random();
            //List<int> ds1 = new List<int>();
            //Console.WriteLine("Nhập n :");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    ds1.Add(r.Next(1,101));
            //}
            //foreach (int i in ds1)
            //{
            //    Console.Write(i + " ");
            //}
            //C#25
            //List<int> ds25 = new List<int>();
            //List<int> ds26 = new List<int>();
            //int count = 0;
            //Console.WriteLine("Nhập n :");
            //int n25 = int.Parse(Console.ReadLine());
            //for(int i = 0; i < n25; i++)
            //{
            //    Console.WriteLine("Nhập vào đây phần tử thứ {0} của ds25", i+1);
            //    int u = int.Parse(Console.ReadLine());
            //    ds25.Add(u);
            //}
            //foreach (int i in ds25)
            //{
            //    int u = i * i; //Math.Pow() và đổi kiểu dữ liệu của ds26
            //    ds26.Add(u);
            //}
            //Console.WriteLine("ds26 là :");
            //foreach ( int i in ds26)
            //{
            //    Console.Write(i+ " ");
            //}
            //foreach( int i in ds25)
            //{
            //    if (i > 50)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Số phần tử lớn hơn 0 trong ds5 là : " + count);
            //C#26
            //List<string> list = new List<string>() { "2+5+7=", "5*10=", "sqrt(16)=", "12%2=", "5//2=" };
            //List<int> traLoi = new List<int>() { 14, 50, 4, 0, 2 };
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i]);
            //    Console.WriteLine();
            //    int ans = int.Parse(Console.ReadLine());
            //    if (ans  == traLoi[i]) 
            //    {
            //        Console.WriteLine("Đúng");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sai , đáp án là: " + traLoi[i]);
            //    }
            //}
            //C#27
            //Console.WriteLine("Nhập vào đây số phần tử của list:");
            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            //List<int> ds27 = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Nhập vào đây phần tử thứ {0}", i+1);
            //    int u = int.Parse(Console.ReadLine());
            //    ds27.Add(u);
            //}
            //foreach (int i in ds27)
            //{
            //    if (i < 5)
            //    {
            //        Console.WriteLine("Số {0} có vị trí index là: {1}", i, ds27.IndexOf(i));
            //        count++;
            //    }
            //}
            //Console.WriteLine("Danh sách có {0} phần tử nhỏ hơn 5", count);

            //C# 28
            List<int> list = new List<int>() { 1, 32, 3, 4, 7, 2, 20 };
            List<int> list2 = new List<int>();
            list2.AddRange(list);
            int a = list2.Max();
            int b = list2.Min();
            list2.Remove(a);
            list2.Remove(b);
            Console.WriteLine("Phần tử lớn thứ 2 trong ds là :"+ list2.Max());
            Console.WriteLine("Phần tử nhỏ thứ 2 trong ds là :" + list2.Min());
            for(int i = 0; i < list.Count; i++) 
            {
                if (list[i] == list2.Max())
                {
                    Console.WriteLine("Index của số lớn thứ 2 trong list là : "+i);
                }
                else if (list[i] == list2.Min())
                {
                    Console.WriteLine("Index của số nhỏ thứ 2 trong list là : " + i);
                }    
            }            
            Console.ReadKey();
        }
    }
}
