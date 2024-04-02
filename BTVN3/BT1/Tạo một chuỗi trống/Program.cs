using System.ComponentModel.DataAnnotations;

string a;


Console.WriteLine("nhap vao day chuoi la chu so:");
a = Console.ReadLine();

int l;
string c = "";

Console.WriteLine("nhap vao day l:");
l = int.Parse(Console.ReadLine());


for (int i = 0; i < a.Length; i++)
{

    c += "0";

    if (l >= (c + a).Length)
    {
        Console.WriteLine(c + a);
    }


}

Console.ReadKey();