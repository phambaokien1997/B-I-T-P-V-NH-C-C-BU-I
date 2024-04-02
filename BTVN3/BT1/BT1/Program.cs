int a;
int b = 0;
Console.WriteLine("Nhap so vao day: ");
a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++) 
{
    
    b += i;
    Console.WriteLine(i);

}


Console.ReadKey();

