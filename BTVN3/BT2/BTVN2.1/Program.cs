//class BTVN2_1
//{
//    static void Main()
//    {
//        List<int> mangNhap = NhapMangSoNguyen();
//        Console.WriteLine("Mang vua nhap la:");
//        foreach (int i in mangNhap)
//        {
//            Console.Write(i + " ");
//        }

//    }
//    static List<int> NhapMangSoNguyen()
//    {
//        List<int> mang = new List<int>();
//        Console.WriteLine("Nhap so luong phan tu cua mang:");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Nhap cac phan tu cua mang:");
//        for (int j = 0; j < n; j++)
//        {
//            Console.WriteLine("Phan tu thu" + (j + 1) + " ");
//            int i = int.Parse(Console.ReadLine());
//            mang.Add(i);
//        }
//        return mang;
//    }
//}


using System;

class BTVN2_1
{
    static void Main()
    {
        List<int> mangNhap = Mangsonguyenvuanhap();
        Console.WriteLine("mang so nguyen vua nhap la:");
        foreach (int i in mangNhap)
        {
            Console.Write(i + " ");

        }
        
    }
    static List<int> Mangsonguyenvuanhap()
    {
        List<int> mang = new List<int>();
        Console.WriteLine("nhap so phan tu cua mang vao day:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("nhap phan tu thu {0} vao day", (i + 1));
            int j = int.Parse(Console.ReadLine());
            mang.Add(j);

        }
        return mang;
    }
    static void tongsochanle(int[] mang)
    {

        int tongChan = 0;
        int tongLe = 0;
        foreach (int i in mang)
        {
            if (i % 2 == 0)
            {
                tongChan += i;
            }
            else
            {
                tongLe += i;
            }
        }
        

    }
    static void Intong()
    {
        
    }
}
    