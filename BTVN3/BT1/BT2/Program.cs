string input;

Console.WriteLine("Nhập vào một chuỗi:");
input = Console.ReadLine();

string reversedString = "";             //tạo chuỗi rỗng
char[] charArray = input.ToCharArray();             // chuyển chuỗi input thành kiểu array
int length = charArray.Length;                  //khởi tạo biến length bằng độ dài của char array.

for (int i = (length - 1); i >= 0; i--) //vòng lặp for chạy ngược từ lớn tới 0.
{
    char phantu = input[i]; // lấy ra phần tử thứ i của chuỗi input
    reversedString = reversedString + phantu; //thêm phần tử đã lấy ra vào chuỗi reversed
}

Console.WriteLine("Chuỗi sau khi đảo ngược: " + reversedString);
