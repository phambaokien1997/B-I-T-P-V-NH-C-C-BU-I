//class BTNV2_4 {
//    static void Main()
//    {
//        int[] mangNhap = Mangsonguyenvuanhap();
//        Console.WriteLine("mang so nguyen vua nhap la:");
//        foreach (int i in mangNhap)
//        {
//            Console.Write(i + " ");

//        }
//    }
//    static int[] Mangsonguyenvuanhap()
//    {
//        List<int> mang = new List<int>();
//        Console.WriteLine("nhap so phan tu cua mang vao day");
//        int n = int.Parse(Console.ReadLine());
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine("nhap phan tu thu {0} vao day", (i + 1));
//            int j = int.Parse(Console.ReadLine());
//            mang.Add(j);
//        }
//        return mang.ToArray();
//    }
//}
using System.Diagnostics.CodeAnalysis;

class BTNV2_4
{
    static void Main()
    {
        int[] mangNhap = Mangsonguyenvuanhap();

        Console.WriteLine("mang so nguyen vua nhap la:");
        mangNhap.ToList();
        foreach (int i in mangNhap)
        {
            Console.Write(i + " ");

        }
        mangchanmangle(mangNhap);
    }
    static int[] Mangsonguyenvuanhap()
    {
        Console.WriteLine("moi ban nhap so luon phan tu:");
        var numberOfElements = int.Parse(Console.ReadLine());
        int[] mang = new int[numberOfElements];
        for(int i= 0; i< mang.Length; i++)
        {
            Console.WriteLine("nhap phan tu thu {0}:", i+1 );
            mang[i] = int.Parse(Console.ReadLine());
    
        }
        return mang;
        

    }
    static void mangchanmangle(int[] mang)
    {
        int sumChan = 0;
        int sumLe = 0;
        foreach (int i in mang)
        {
            
            if (i % 2 == 0)
            {
                sumChan += i;
            }
            else
            {
                sumLe += i;
            }    
        }
        Console.WriteLine("tong chan la:" + sumChan);
        Console.WriteLine("tong le la:" + sumLe);
    }
    
}
