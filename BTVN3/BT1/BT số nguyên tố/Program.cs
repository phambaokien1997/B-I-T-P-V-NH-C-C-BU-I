int a;
string l;

Console.WriteLine("nhap vao day so nguyen to:");
a = int.Parse(Console.ReadLine());


while (a > 0 && a % 1 == 0 && a % a == 0)
{
    
    
    for (int i = 2; i < a; i++)
    {
        if (a % i == 0)
        {
            Console.WriteLine("{0} k phai la so nt", a);
            break;

        }
        else
        {
            Console.WriteLine("la snt");
            break;
        }

    }
    Console.WriteLine("Ban co muon ket thuc ct k ?");
    l = Console.ReadLine();
    if (l == "khong")
    {
        Console.WriteLine("nhap vao day so nguyen to:");
        a = int.Parse(Console.ReadLine());
    }
    else { break; }
    

}

Console.ReadKey();