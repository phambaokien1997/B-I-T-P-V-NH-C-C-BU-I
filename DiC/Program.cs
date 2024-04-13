using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace DiC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            //1 khai báo
            Dictionary<int, string> dic = new Dictionary<int, string>();
            //2 khởi tạo và gán giá trị
            Dictionary<int, string> dic2 = new Dictionary<int, string>() { { 1, "Phạm Bảo Kiên" }, { 2, "Phạm Bảo Khiêm" } };
            //3 key là biển số xe string
            // value là cmnd int
            Dictionary<string, int> dic3 = new Dictionary<string, int>() { { "43D1123213", 201745993 }, { "43D212323", 201846546 } };
            //4 thêm vào DIC
            dic.Add(1, "PBK");
            dic.Add(2, "PBKH");
            dic.Add(3, "DDU");
            dic.Add(4, "TDH");
            //5 Duyệt DIC
            foreach(KeyValuePair<int,string> kvp in dic)
            {
                Console.WriteLine(kvp);
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);
                 
            }
            //6 dic.containkey() kiểm tra xem 1 key có tồn tại trong dic không
            //true: nếu tồn tại
            //false" nếu không tồn tại
            bool kq = dic.ContainsKey(1);
            //7 dic.containvalues
            bool check = dic.ContainsValue("PVB");
            Console.WriteLine(kq);
            Console.WriteLine(check);
            //8.1 lấy value từ key
            string name = dic[1];
            Console.WriteLine(name);
            //8.2 gán giá trị
            dic[2] = "PVB";
            Console.WriteLine(dic[2]);
            //9.1 xóa theo key 
            dic.Remove(4);
            foreach (KeyValuePair<int,string> kvp in dic) { Console.WriteLine(kvp); }
            //10 xóa toàn bộ
            Console.WriteLine("Số phần tử trước khi xóa" + dic.Count());
            dic.Clear();
            Console.WriteLine("Số phần tử sau khi xóa" + dic.Count());
            //11 chuyển values sang list
            Dictionary<string, int> dic4 = new Dictionary<string, int>() { { "43D1123213", 201745993 }, { "43D212323", 201846546 } };
            List<int> ds = new List<int>();
            ds = dic4.Values.ToList();
            Console.WriteLine("Danh sách values là :");
            foreach(int i in ds) { Console.WriteLine(i); }
            //12 chuyển key sang list
            Dictionary<string, int> dic5 = new Dictionary<string, int>() { { "43D1123213", 201745993 }, { "43D212323", 201846546 } };
            List<string> ds2 = new List<string>();
            ds2 = dic5.Keys.ToList();
            Console.WriteLine("Danh sách key là:");
            foreach(string s in ds2) { Console.WriteLine(s); }




            Console.ReadKey();
            

        }
    }
}
