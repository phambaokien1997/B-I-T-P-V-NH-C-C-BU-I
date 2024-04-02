class BTVN2_2
{

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
    static void InMangSoLeVaChan(List<int> mang)
    {
        List<int> mangLe = new List<int>();
        List<int> mangChan = new List<int>();

        foreach (int phanTu in mang)
        {
            if (phanTu % 2 == 0)
            {
                mangChan.Add(phanTu);
            }
            else
            {
                mangLe.Add(phanTu);
            }
        }

        Console.WriteLine("Mang so chan:");
        InMang(mangLe);
        Console.WriteLine();
        Console.WriteLine("Mang so le" +
            ":");
        InMang(mangChan);
    }
    static void InMang(List<int> mang)
    {
        foreach (int phanTu in mang)
        {
            Console.Write(phanTu + " ");
        }
    }
    static void Main()
    {
        List<int> mangNhap = Mangsonguyenvuanhap();

        Console.WriteLine("mang so nguyen vua nhap la:");
        foreach (int i in mangNhap)
        {
            Console.Write(i + " ");


        }
        Console.WriteLine();

        InMangSoLeVaChan(mangNhap);


    }
}