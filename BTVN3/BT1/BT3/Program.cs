string a;
Console.WriteLine("Nhap vao day mot chuot:");
a=Console.ReadLine();
//char[] array = a.ToCharArray();
//int length = array.Length;

char b;
int d = 0;
Console.WriteLine("Nhap vao 1 ki tu ban can tim:");
b = char.Parse(Console.ReadLine());

for(int i = 0; i < a.Length; i++ )
{
    char c = a[i];
    
    if (c == b)
    {
        d = d + 1;
    }
    
    
}

//Console.WriteLine("Ky tu {0} co {1} xuat hien trong chuoi {2}" , b,d,a);
Console.WriteLine($"Ky tu {b} co {d} xuat hien trong chuoi {a}");