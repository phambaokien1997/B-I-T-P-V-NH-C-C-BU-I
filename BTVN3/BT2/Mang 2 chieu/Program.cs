//1. mảng 2 chiều
//kieudulieu[,] arr = new kieudulieu[so_hang,so_cot]
int[,] arr = new int[3, 5];
int[,] arr2 = new int[2, 3] { { 1, 2, 5 }, {3, 5, 4 }};
//3. nhập giá trị ngẫu nhiên cho mảng dùng 2 vòng for
Random r = new Random();
int dong = 3;
int cot = 4;
int[,] arr3 = new int[dong, cot];
for(int i = 0; i < dong; i++)
{
    for (int j = 0; j < cot; j++)
    {
        //Console.Write(i);
        //Console.Write(j+"\t");
        arr3[i, j] = r.Next(51);
    }
    Console.WriteLine();

}
Console.WriteLine(arr3[0,0]);
Console.WriteLine(arr3[0,2]);


//Xuất mảng bất kỳ
//Getlength(0) get dòng của mảng
//Getlength(1) get cột của mảng
Console.WriteLine("Ma tran ngau nhien vua tao ra la:");
for (int i = 0; i< arr3.GetLength(0); i++)
{
    for (int j = 0;j< arr3.GetLength(1); j++)
    {
        Console.Write(arr3[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.ReadKey();