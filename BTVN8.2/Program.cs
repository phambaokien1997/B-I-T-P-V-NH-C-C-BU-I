using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Product> products = new List<Product>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Nhập liệu cho mỗi loại hàng 2 sản phẩm");
                Console.WriteLine("2. Thực hiện mua hàng và hiển thị số lượng còn lại trong cửa hàng");
                Console.WriteLine("3. Thống kê các loại hàng hóa sắp hết hạn");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                string choice = Console.ReadLine();
                InputValidator validator = new InputValidator();
                if (string.IsNullOrWhiteSpace(choice) || !validator.ContainsOnlyDigits(choice))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại!");
                    continue;
                }
                switch (choice)
                {
                    case "1":
                        InputProducts(products);
                        break;
                    case "2":
                        BuyProduct(products);
                        break;
                    case "3":
                        DisplayExpiringProducts(products);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ!");
                        break;
                }
            }
        }
        static void InputProducts(List<Product> products)
        {
            InputValidator validator = new InputValidator();
            Console.WriteLine("Nhập thông tin cho hàng điện tử:");
            for (int i = 0; i < 2; i++)
            {
                ElectronicProduct electronicProduct = new ElectronicProduct();
                electronicProduct.InputProductInfo();
                products.Add(electronicProduct);
            }
            Console.WriteLine("Nhập thông tin cho hàng thực phẩm:");
            for (int i = 0; i < 2; i++)
            {
                FoodProduct foodProduct = new FoodProduct();
                foodProduct.InputProductInfo();
                products.Add(foodProduct);
            }
            Console.WriteLine("Nhập thông tin cho hàng quần áo:");
            for (int i = 0; i < 2; i++)
            {
                ClothingProduct clothingProduct = new ClothingProduct();
                clothingProduct.InputProductInfo();
                products.Add(clothingProduct);
            }
        }
        static void BuyProduct(List<Product> products)
        {
            Console.WriteLine("Danh sách các sản phẩm:");
            DisplayProducts(products);
            Console.Write("Nhập mã hàng bạn muốn mua: ");
            string productCode = Console.ReadLine();
            Product selectedProduct = products.Find(product => product.Code == productCode);
            if (selectedProduct != null)
            {
                selectedProduct.Buy();
                Console.WriteLine("Mua hàng thành công!");
                products.Remove(selectedProduct);
            }
            else
            {
                Console.WriteLine("Không tìm thấy sản phẩm với mã hàng đã nhập.");
            }
        }
        static void DisplayExpiringProducts(List<Product> products)
        {
            Console.WriteLine("Danh sách các sản phẩm sắp hết hạn:");
            foreach (var product in products)
            {
                if (product.IsExpiringSoon())
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }
        static void DisplayProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}