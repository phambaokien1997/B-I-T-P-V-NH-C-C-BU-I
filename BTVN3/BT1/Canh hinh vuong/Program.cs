int a;
string b = "";
int vonglap = 0;
Console.WriteLine("nhap a");
a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    b += "*";
    Console.WriteLine(b);
}

Console.ReadKey();

