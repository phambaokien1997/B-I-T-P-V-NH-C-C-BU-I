float d1;
float r1;
float S1;
float P1;
Console.WriteLine("chieu dai hinh chu nhat:");
d1 = float.Parse(Console.ReadLine());
Console.WriteLine("chieu rong hinh chu nhat:");
r1 = float.Parse(Console.ReadLine());
S1 = d1 * r1;
P1 = (d1 + r1) * 2;
Console.WriteLine("chu vi hinh chu nhat la :{0}", P1);
Console.WriteLine("dien tich hinh chu nhat la:{0}", S1);


float a2;
float b2;
float c2;
float ha2;
float P2;
float S2;

Console.WriteLine("nhap cac canh cua tam giac");
a2 = float.Parse(Console.ReadLine());
b2 = float.Parse(Console.ReadLine());
c2 = float.Parse(Console.ReadLine());
Console.WriteLine("nhap chieu cao tu a:");
ha2 = float.Parse(Console.ReadLine());

P2 = a2 + b2 + c2;
S2 = (a2 * ha2) / 2;
Console.WriteLine("Chu vi cua hinh tam giac la :" + P2);
Console.WriteLine("Dien tich cua hinh tam giac la:" + S2);



float r3;
double C3;
double P3 = 3.14;
double S3;
Console.WriteLine("Nhap tu ban kinh hinh tron:");
r3 = float.Parse(Console.ReadLine());
C3 = 2 * P3 * r3;
S3 = P3 * r3 * r3;
Console.WriteLine("Dien tich cua hinh tron la:" + S3);
Console.WriteLine("Chu vi cua hinh tron la:" + C3);


float a4;
float C4;
float S4;
Console.WriteLine("nhap canh cua hinh vuong");
a4 = float.Parse(Console.ReadLine());
C4 = a4 * 4;
S4 = a4 * a4;
Console.WriteLine("Chu vi hinh vuong la: {0}, dien tich hinh vuong la :{1}", C4, S4);

float canhht1;
float canhht2;
float dl;
float db;
float h5;
float P5;
float S5;
Console.WriteLine("Nhap doan nam giua 1 cua hinh thang");
canhht1 = float.Parse(Console.ReadLine());
Console.WriteLine("Nhap doan nam giua 2 cua hinh thang");
canhht2 = float.Parse(Console.ReadLine());
Console.WriteLine("Nhap day lon hinh thang");
dl = float.Parse(Console.ReadLine());
Console.WriteLine("Nhap day be hinh thang");
db = float.Parse(Console.ReadLine());
Console.WriteLine("Nhap chieu cao cua hinh thang");
h5 = float.Parse(Console.ReadLine());
P5 = canhht1 + canhht2 + dl + db;
S5 = h5 * ((dl + db) / 2);
Console.WriteLine("Chu vi cua hinh thang la :{0},Dien tich cua hinh thang la :{1}", P5, S5);
Console.ReadKey();
