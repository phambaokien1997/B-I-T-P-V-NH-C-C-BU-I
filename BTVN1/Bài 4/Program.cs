﻿float a;
float b;
float c;
float d;
float e;
Console.WriteLine("nhap a:");
a = float.Parse(Console.ReadLine());
Console.WriteLine("nhap b:");
b = float.Parse(Console.ReadLine());
Console.WriteLine("nhap c:");
c = float.Parse(Console.ReadLine());
d = a + b + c;
e = a - b;
Console.WriteLine("tong cua 3 so la:{0}, hieu cua a và b là:{1}",d,e);
Console.ReadKey();