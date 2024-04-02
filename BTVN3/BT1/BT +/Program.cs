// Tìm số hoàn hảo trong khoảng từ 1-1000

//Một số hoàn hảo là một số tự nhiên mà tổng của tất cả các ước số của nó (không tính chính nó) bằng chính nó.


using System.ComponentModel.Design;

int a;


for (a = 1; a < 1000; a++) 
{
    int tong = 0;
    for (int i = 1; i < a; i++)
    {
        if (a % i == 0)
        {
            tong += i;
            
        }
        







    }
    if (tong == a)
    {
        Console.WriteLine(" cac so la : " + a);



    }



}

    


    
Console.ReadKey();
