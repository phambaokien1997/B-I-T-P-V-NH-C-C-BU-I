Console.OutputEncoding=
int songuyen;
int a;
Console.WriteLine("Nhap 1 so nguyen vao ban phim");
songuyen=int.Parse(Console.ReadLine());
Console.Write("Day so nguyen da duoc nhap la: ");
for (int i = 0; i < songuyen; i++)
{
    Console.Write(i+" ");
}

Console.ReadKey(true);


