

int a;
int tong = 0;
bool kq = true;

do
{
    Console.WriteLine("nhap a:");
    a = int.Parse(Console.ReadLine());
    kq = a < 0;
    if (kq)
        Console.WriteLine("moi ban nhap lai");

    else
    {
        {
            for (int i = 0; (i < a); i += 2)
            {

                tong = tong+i;
            }

            Console.WriteLine("tong=" + tong);

        }
    }
} while (kq);
Console.ReadKey();
