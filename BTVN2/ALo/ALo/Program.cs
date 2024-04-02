
//using System.Runtime.Intrinsics.X86;

//var b = "1234";
//var c = b[1];
//var d = new char[4] { '1', '2', '3', '4' };
//Console.WriteLine(d[1]);
//Console.WriteLine(c);
//b = "abc" + b;
//Console.WriteLine(b[1]);
//var e = new char[4] { '1', 'b', '3', '5' };
//d = e;
//d[1] = 'z';
//Console.WriteLine(e[1]);
//string input;
//string output = "";
//Console.WriteLine("Nhap chuoi di:");
//input = Console.ReadLine();
//Console.WriteLine("Chuoi ban vua nhap la: {0}", input);

//Console.WriteLine("Chuoi sau khi dao nguoc la:{0}", output);
//Console.ReadKey();
var str = "1234";
string reversedString = "";
for (int i = str.Length - 1; i >= 0; i--)
{
    reversedString += str[i];
}
Console.WriteLine(reversedString);
