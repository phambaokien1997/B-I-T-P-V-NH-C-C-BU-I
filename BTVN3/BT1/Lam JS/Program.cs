//Quizz0:
//string chuoi1;

//bool kq=true;
//do
//{
//    Console.WriteLine("Nhap mot chuoi:");
//    chuoi1 = Console.ReadLine();
//    if (chuoi1.Length >= 8)
//    {
//        Console.WriteLine("Chuoi nay ok");
//        break;


//    }
//    else
//    {
//        Console.WriteLine("Ngan qua dai them ti nua");
//        kq = false;
//    }
//}
//while (!kq);
//Quiz1:'
//bool kq = false;

//while (!kq)
//{
//    int a;
//    Console.WriteLine("Nhap vao day mot so:");
//    a = int.Parse(Console.ReadLine());
//    if (a >= 18)
//    {
//        Console.WriteLine("Đủ 18 thì quẩy tiếp");
//        kq = false;
//    }
//    else if (a <= 18 && a >= 16)
//    {
//        Console.WriteLine("Đợi thêm ít năm nữa");
//        kq = false;
//    }
//    else { Console.WriteLine("Còn quá nà trẻ");
//        kq = false;
//    }
//}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Khởi tạo mảng số nguyên
        int[] numbers = { 5, 3, 9, 1, 7 };

        // Gọi hàm sắp xếp tăng dần
        SortAscending(numbers);

        // In ra mảng sau khi đã sắp xếp
        Console.WriteLine("Dãy số sau khi sắp xếp tăng dần:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void SortAscending(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int current = arr[i];
            int j = i - 1;

            // Di chuyển các phần tử lớn hơn current về phía sau
            while (j >= 0 && arr[j] > current)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            // Đặt current vào vị trí đúng trong dãy đã sắp xếp
            arr[j + 1] = current;
        }
    }
}

