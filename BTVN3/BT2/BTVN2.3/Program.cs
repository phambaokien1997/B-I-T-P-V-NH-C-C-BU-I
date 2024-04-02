using System.Text;

class Program
{   
    static List<int> NhapMangSoNguyen()
    {
        Console.InputEncoding = Encoding.UTF8;
        List<int> mang = new List<int>();

        Console.WriteLine("Nhập số phần tử của mảng:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhập phần tử thứ {0}:", (i + 1));
            int phanTu = int.Parse(Console.ReadLine());
            mang.Add(phanTu);
        }

        return mang;
    }

    static void SapXepTangDan(List<int> mang)
    {
        mang.Sort();
    }

    static void SapXepGiamDan(List<int> mang)
    {
        mang.Sort();
        mang.Reverse();
    }

    static void Main()
    {
        
        List<int> mangNhap = NhapMangSoNguyen();

        Console.WriteLine("Mảng số nguyên vừa nhập là:");
        foreach (int phanTu in mangNhap)
        {
            Console.Write(phanTu + " ");
        }
        Console.WriteLine();

        
        SapXepTangDan(mangNhap);
        Console.WriteLine("Mảng số nguyên sau khi sắp xếp tăng dần:");
        foreach (int phanTu in mangNhap)
        {
            Console.Write(phanTu + " ");
        }
        Console.WriteLine();

       
        SapXepGiamDan(mangNhap);
        Console.WriteLine("Mảng số nguyên sau khi sắp xếp giảm dần:");
        foreach (int phanTu in mangNhap)
        {
            Console.Write(phanTu + " ");
        }
    }
}