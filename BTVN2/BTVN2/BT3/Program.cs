int thang;

Console.WriteLine("Nhap thang can biet:");
thang = int.Parse(Console.ReadLine());


if (thang > 0 && thang <= 12)
{
    switch (thang)
    {
        case 1:
            Console.WriteLine("Day la thang co 31 ngay");
            break;
        case 2:
            Console.WriteLine("Day khong phai la thang co 31 ngay");
            break;
        case 3:
            Console.WriteLine("Day la thang co 31 ngay");
            break;
        case 4:
            Console.WriteLine("Day khong phai la thang co 31 ngay");
            break;
        case 5:
            Console.WriteLine("Day la thang co 31 ngay");
            break;
        case 6:
            Console.WriteLine("Day khong phai la thang co 31 ngay");
            break;
        case 7:
            Console.WriteLine("Day la thang co 31 ngay");
            break;
        case 8:
            Console.WriteLine("Day la thang co 31 ngay");
            break;
        case 9:
            Console.WriteLine("Day khong phai la thang co 31 ngay");
            break;
        case 10:
            Console.WriteLine("Day la thang co 31 ngay");
            break;
        case 11:
            Console.WriteLine("Day khong phai la thang co 31 ngay");
            break;
        case 12:
            Console.WriteLine("Day la thang co 31 ngay");
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;



    }
}
else {
    Console.WriteLine("ban nhap sai roi");
        }
Console.ReadKey();