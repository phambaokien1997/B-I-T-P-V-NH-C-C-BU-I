string input;
Console.WriteLine("nhap mot chuoi:");
input = Console.ReadLine();
char[] charArray = input.ToCharArray();
Array.Reverse(charArray);ngu
string reversedString = new string(charArray);

Console.WriteLine("Chuỗi đảo ngược: " + reversedString);        

    