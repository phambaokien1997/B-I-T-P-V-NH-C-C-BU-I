using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BTVN5._2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            CheckInput.Bai2 bai2 = new CheckInput.Bai2();
            bai2.Codebai2();
        }
    }
    internal class CheckInput
    {
        
        public bool ContainsNumber(string input)
        {
            if (input.Any(char.IsDigit))
            {
                Console.WriteLine("Không được chứa chữ số!");
                return true;
            }
            else
                return false;
        }
        public bool CheckContainSpecialChar(string input)
        {
            Regex specialCharRegex = new Regex(@"[~`!@#$%^&*()+=|\\{}':;,.<>?/""-]");
            if (specialCharRegex.IsMatch(input))
            {
                Console.WriteLine("Không được chứa kí tự đặc biệt!");
                return true;
            }
            else
                return false;
        }
        public bool CheckIsNullOrWhiteSpace(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Không được để trống hay chỉ chứa khoảng trắng!");
                return true;
            }
            else
                return false;
        }     
        public bool CheckExpiredDate(string input)
        {
            if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                DateTime now = DateTime.Now;
                TimeSpan interval = now - date;
                if (interval.Days < 0)
                    return true;
                else
                {
                    Console.WriteLine("Ngày hết hạn không được nhỏ hơn thời gian hiện tại!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Định dạng ngày không hợp lệ!");
                return false;
            }
        }
        internal class Bai2 : CheckInput
        {
            internal struct Product
            {
                internal string ProductName { get; set; }
                internal double ProductPrice { get; set; }
                internal DateTime ExpiredDate { get; set; }

                internal int CalculateExpiredDay()
                {
                    DateTime now = DateTime.Now;
                    TimeSpan exp_day = this.ExpiredDate - now;
                    if (exp_day.Days < 180 && exp_day.Days > 0)
                        return exp_day.Days;
                    else
                        return 0;
                }
            }

            List<Product> list_product = new List<Product>();
            public void Codebai2()
            {
                bool flag = false;
                int choice = -1;
                do
                {
                    MenuManageProduct();
                    if (!Int32.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Dữ liệu nhập vào phải là số và không được bỏ trống!");
                    }
                    else
                    {
                        switch (choice)
                        {
                            case 0: flag = true; break;
                            case 1:
                                InputListProduct();
                                break;
                            case 2:
                                DisplayListProduct();
                                Console.WriteLine();
                                break;
                            case 3:
                                ExpiredDateWithin30Day();
                                break;
                            case 4:
                                NameOver10Char();
                                Console.WriteLine();
                                break;
                            default: Console.WriteLine("Dữ liệu nhập vào không hợp lệ, vui lòng nhập lại!"); break;
                        }
                    }
                } while (!flag);
            }
            public void MenuManageProduct()
            {
                Console.WriteLine("Quản Lý Sản Phẩm");
                Console.WriteLine("1. Nhập danh sách sản phẩm");
                Console.WriteLine("2. Hiển thị danh sách sản phẩm đã nhập");
                Console.WriteLine("3. Hiển thị ra các sản phẩm có ngày hết hạn trong vòng 30 ngày");
                Console.WriteLine("4. Hiển thị các sản phẩm có tên dài hơn 10 kí tự");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("Hãy nhập lựa chọn của bạn: ");
            }
            public void InputListProduct()
            {
                int num;
                Console.Write("Số lượng sản phẩm muốn thêm: ");
                if (!Int32.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Dữ liệu nhập vào phải là số nguyên và không được bỏ trống!");
                }
                else
                {
                    list_product = new List<Product>(num);
                    for (int i = 0; i < num; i++)
                    {
                        Console.WriteLine("\nNhập thông tin sản phẩm thứ " + (i + 1));
                        Product new_product = new Product();
                        InputProduct(ref new_product);
                        list_product.Add(new_product);
                    }
                }
            }
            public void InputProduct(ref Product product)
            {
                bool valid = true;
                // Nhập tên sản phẩm
                do
                {
                    Console.Write("Nhập tên sản phẩm: ");
                    product.ProductName = Console.ReadLine();
                    if (CheckContainSpecialChar(product.ProductName) || CheckIsNullOrWhiteSpace(product.ProductName) || ContainsNumber(product.ProductName))
                        valid = false;
                    else
                        valid = true;
                } while (!valid);

                // Nhập giá sản phẩm
                do
                {
                    double price;
                    Console.Write("Nhập giá sản phẩm: ");
                    if (double.TryParse(Console.ReadLine(), out price))
                    {
                        if (price <= 0)
                        {
                            Console.WriteLine("Giá sản phẩm không thể âm và không bằng 0!");
                            valid = false;
                        }
                        else
                        {
                            product.ProductPrice = price;
                            valid = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Giá sản phẩm không được quá lớn, không chứa kí tự, để trống hay khoảng trắng!");
                        valid = false;
                    }
                } while (!valid);

                // Nhập ngày hết hạn
                do
                {
                    Console.Write("Nhập ngày hết hạn: ");
                    string exp_date = Console.ReadLine();
                    if (CheckExpiredDate(exp_date))
                    {
                        product.ExpiredDate = DateTime.ParseExact(exp_date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None);
                        if (product.CalculateExpiredDay() == 0)
                            valid = false;
                        else
                            valid = true;
                    }
                    else
                        valid = false;
                } while (!valid);
            }
            public void DisplayListProduct()
            {
                Console.WriteLine("\nDanh sách các sản phẩm hiện có: ");
                int count = 1;
                foreach (Product product in list_product)
                {
                    if (count <= list_product.Count)
                    {
                        Console.Write("\n" + count + ". ");
                        DisplayProduct(product);
                        count++;
                    }
                }
            }
            public void DisplayProduct(Product product)
            {
                Console.Write("Tên sản phẩm: " + product.ProductName + ", Giá sản phẩm: " + product.ProductPrice + ", Ngày hết hạn: " + product.ExpiredDate);
            }
            public void ExpiredDateWithin30Day()
            {
                Console.WriteLine("\nDanh sách các sản phẩm có ngày hết hạn trong vòng 30 ngày: ");
                int count = 1;
                foreach (Product product in list_product)
                {
                    if (count <= list_product.Count && product.CalculateExpiredDay() <= 30)
                    {
                        Console.Write("\n" + count + ". ");
                        DisplayProduct(product);
                        count++;
                    }
                }
            }
            public void NameOver10Char()
            {
                Console.WriteLine("\nDanh sách các sản phẩm có tên dài hơn 10 kí tự: ");
                int count = 1;
                foreach (Product product in list_product)
                {
                    if (count <= list_product.Count && product.ProductName.Length > 10)
                    {
                        Console.Write("\n" + count + ". ");
                        DisplayProduct(product);
                        count++;
                    }
                }
            }
        }
    }
}
    

