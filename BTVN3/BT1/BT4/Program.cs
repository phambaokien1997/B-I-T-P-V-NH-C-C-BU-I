int a;
int i = 1;
int b;

Console.WriteLine("Moi ban nhap mot so vao day:");
a = int.Parse(Console.ReadLine());
b = a;
Console.WriteLine("So ban vua nhap la: {0}", a);
do
{

    {

        a *= (b - i);

        i++;

    }
    
    

}
while ((b -i != 1));
Console.WriteLine(a);
