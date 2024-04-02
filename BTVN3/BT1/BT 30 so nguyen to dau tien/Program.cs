//So nguyen to la so lon hon 1 
//int a;
//Console.WriteLine("nhap so vao de:");
//a = int.Parse(Console.ReadLine());
//if (a > 1 && a % 1 == 0 && a % a == 0)
//{
//    for (int i = 2; i < a; i++)
//    {
//        if (a % i == 0)
//        {
//            Console.WriteLine("day k phai la so nguyen to");
//            break;
//        }
//        else { Console.WriteLine("day la so nguyen to"); }
//        break;
//    }
//}
//Console.ReadKey();

//int a = 2;

//int b;
//Console.WriteLine("nhap mot so");
//b=int.Parse(Console.ReadLine());
//while (a <= b )
//{
//    int uoc = 0;
//    for (int i = 1; i <= a; i++)
//    {

//        if (a % i == 0)
//        {
//            uoc++;

//        }

//    }
//    if (uoc == 2)
//    {
//        Console.WriteLine(a);
//    }


//    a++;


//}
//Console.ReadKey();
int a = 2;
int count = 0;
int c; 
Console.WriteLine("nhap mot so");
c = int.Parse(Console.ReadLine());
Console.WriteLine("Cac so nguyen ban can xuat ra la");
for (int b= 0; c>count; b++)
{
    while (a <= b)
    {
        int uoc = 0;
        for (int i = 1; i <= a; i++)
        {
            if (a % i == 0)
            {
                uoc++;
            }
        }
        if (uoc == 2)
        {
            Console.WriteLine(a);
            count++;
        }
       a++;
    }
}
Console.ReadKey();





















