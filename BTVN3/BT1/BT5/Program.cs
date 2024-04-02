bool check = true;
do

{
    string a;
    Console.WriteLine("Nhap di:");
    a = Console.ReadLine();
    char b = '@';

    for (int i = 0; i < a.Length; i++)
    {
        char c = a[i];
        if (c == b && a.Length >= 6 && a.Length <= 12)
        {
            Console.WriteLine("Mat khau dung");
            check = false;
        }
    }

}
while (check);