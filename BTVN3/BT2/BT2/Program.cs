////1 khai bao mảng
//int[] stt;
//char[] ch;
//string[] ten;

////2. khởi tạo mảng
////ten mang= new Kieudulieu[soPhanTu]
//stt = new int[5]; // mặc định phần tử là 0
//foreach (int i in stt)
//{
//    Console.Write(i + "\t");
//}
//Console.WriteLine();
//Console.WriteLine("mảng số thứ tự 2 là:");
//int[] stt2 = new int[7];
//foreach (int i in stt2)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();
//Console.WriteLine("mang 2 la");
////3. khoi tao và gán luôn giá trị cho mảng
//// kiểu dữ liệu [] tên mảng= new Kieudulieu[Số_phần_tử]{pt1, pt2, pt3,...};
//int[] mang2 = { 1, 2, 4, 5, 6 };
//foreach (int i in mang2)
//{
//    Console.Write(i + " ");
//}

////4. khởi tạo 1 mảng ngẫu nhiên
//Console.WriteLine();
//Console.WriteLine("mang 3 la:");
//Random r = new Random();
//int[] mang3 =/* new int[3] */{ r.Next(51), r.Next(21), r.Next(3) };
//foreach (int i in mang3)
//{
//    Console.Write(i + " ");

//}
//Console.WriteLine();
////7. kiểm tra length
//int dai = mang3.Length;
//Console.WriteLine("chieu dai cau mang 3 la:" +dai);

////8 truy xuất phần tử qua index
//int[] mang4 = { 1, 2, 3, 4, 7 };
//Console.WriteLine(mang4[1]);
//Console.WriteLine(mang4[4]);
//Console.WriteLine(mang4[mang4.Length-1]);

////9 Thay đổi giá trị của mảng bằng cách gọi index
//int[] mang5 = {1,3,5,9,8};
//mang5[1] = 10; // thay đổi phần tử thứ 2 của mảng từ 3 thành 10
//Console.WriteLine("mang 5 sau khi thay doi gia tri la:");
//foreach (int i in mang5)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();
////12. phép gán mảng: gán mảng mới = mảng đã tồn tại ( tham chiếu cùng vùng nhớ)
//int[] mang8 = {1,2,3,4,5,6,7};
//int[] mang9 = mang8;
//mang8[0] = 20;
//Console.WriteLine("mang 8 sau doi tai vi tri index 0 la:" + mang8[0]);
//Console.WriteLine("mang 9 sau doi tai vi tri index 0 la:" + mang9[0]);
////13 Copyto
//int[] mang10 = { 100, 200, 300, 400, 500 };
//int[] mang11 = { 1, 2, 3, 4, 5, 6, 7 };
//mang10.CopyTo(mang11, 1);
//Console.WriteLine("mang 11 sau khi copy mang 10 qua la:");
//foreach (int i in mang11)
//{
//    Console.Write(i + " ");
//}
////14 copy
//int[] mang12 = { 100, 200, 300, 400, 500 };
//int[] mang13 = new int[5];
//Array.Copy(mang12, mang13, 4);
//Console.WriteLine("mang 13 la:");
//foreach(int i in mang13)
//{
//    Console.Write(i+ " ");
//}

////15 Clone (tạo ra mảng mới trên vùng nhớ mới) COPY TẤT CẢ CÁC PHẦN TỦ CỦA MẢNG CŨ SANG MẢNG MỚI
//Console.WriteLine();
//int[] mang14 = { 1, 2, 3, 4, 5, 6 };
//int[] mang15 = (int[])mang14.Clone();
//foreach(int i in mang15)
//{
//    Console.Write(i + " ");
//}
////16 Reverse: Đảo ngược mảng
//Console.WriteLine();
//int[] mang16 = {1,2,3,4,5,6,7,8};
//Array.Reverse(mang16);
//Console.WriteLine("mang 16 sau khi dao nguoc la:");
//foreach(int i in mang16)
//{
//    Console.Write(i + " ");
//}
////17 Sort: Sắp xếp tăng dần
//Console.WriteLine();
//int[] mang17 = { 1, 0, 4, 3, 10, 3, 5 };
//Array.Sort(mang17);
//Console.WriteLine("mang 17 sau khi sap xep tang dan la:");
//foreach(int i in mang17)
//{
//    Console.Write(i + " ");
//}    
//Console.ReadKey();

//1 Nhập giá trị ngẫu nhiên
int n;
Console.WriteLine("Nhap n vao day");
n = int.Parse(Console.ReadLine());
int[] mangbai1 = new int[n];
Random r = new Random();
for (int i = 0; i < n; i++)
{
    mangbai1[i] = r.Next(101);
}
//2 xuất mảng

Console.WriteLine("mang ngau nhien la:");
foreach (int i in mangbai1)
{
    Console.Write(i + " ");
}
//3 đảo ngược mảng lại
Console.WriteLine();
Console.WriteLine("mang sau khi dao nguoc la:");
Array.Reverse(mangbai1);
foreach (int i in mangbai1)
{
    Console.Write(i + " ");
}
//4 Sort mảng
Console.WriteLine();
Console.WriteLine("mang sau khi sap xep tang dan la:");
Array.Sort(mangbai1);
foreach (int i in mangbai1)
{
    Console.Write(i + " ");
}
//5 Tổng các phần tử
int sum = 0;
Console.WriteLine();
for (int i = 0; i < mangbai1.Length; i++)
{
    sum += mangbai1[i];
}
Console.WriteLine("tong cua cac phan tu trong mangbai1 la:" + sum);
//6 Tìm kiếm trong mảng (tìm BinarySearch chỉ áp dụng khi mảng đã sắp xếp)
Console.WriteLine("moi ban nhap vao so can tim");
int so = int.Parse(Console.ReadLine());
int kq = Array.BinarySearch(mangbai1, so);
if (kq == -1)
{
    Console.WriteLine("khong tim thay so can tim");
}
else
{
    Console.WriteLine("tim thay so {0} o vi tri index {1}", so, kq);
}
//7 TÌm kiếm trong mảng theo cách thông thường
Console.WriteLine("moi ban nhap vao so can tim");
int demm = 0;
int sott = int.Parse(Console.ReadLine());
for (int i = 0; i < mangbai1.Length; i++)
{
    if (mangbai1[i] == sott)
    {
        demm++;
        if (demm == 1)
        {
            Console.WriteLine("co so {0} tai vi tri index {1}", sott, i);
            break;
        }

        else
        {
            Console.WriteLine("k tim thay");

            break;
        }

    }
}






    Console.ReadKey();

