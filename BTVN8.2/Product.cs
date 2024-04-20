using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN8._2
{
    abstract class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public virtual void InputProductInfo()
        {
            InputValidator validator = new InputValidator();
            Console.Write("Mã hàng: ");
            string codeInput = Console.ReadLine();
            if (!validator.IsValidInteger(codeInput))
            {
                Console.WriteLine("Mã hàng phải là một số nguyên.");
                return;
            }
            Code = codeInput;
            Console.Write("Tên hàng: ");
            string nameInput = Console.ReadLine();
            if (validator.ContainsDigits(nameInput))
            {
                Console.WriteLine("Tên hàng không được chứa số.");
                return;
            }
            Name = nameInput;
            Console.Write("Giá tiền: ");
            string priceInput = Console.ReadLine();
            if (!validator.IsValidDecimal(priceInput))
            {
                Console.WriteLine("Giá tiền phải là một số.");
                return;
            }
            Price = decimal.Parse(priceInput);
            Console.Write("Ngày sản xuất (yyyy-MM-dd): ");
            string manufactureDateString = Console.ReadLine();
            if (!validator.IsValidDate(manufactureDateString))
            {
                Console.WriteLine("Ngày sản xuất không hợp lệ.");
                return;
            }
            ManufactureDate = DateTime.Parse(manufactureDateString);
            Console.Write("Ngày hết hạn (nếu có, yyyy-MM-dd): ");
            string expiryDateString = Console.ReadLine();
            if (!string.IsNullOrEmpty(expiryDateString))
            {
                if (!validator.IsValidDate(expiryDateString))
                {
                    Console.WriteLine("Ngày hết hạn không hợp lệ.");
                    return;
                }
                ExpiryDate = DateTime.Parse(expiryDateString);
            }
        }
        public void Buy()
        {
            Console.WriteLine("Mua hàng");
        }
        public bool IsExpiringSoon()
        {
            if (ExpiryDate.HasValue)
            {
                TimeSpan remainingDays = ExpiryDate.Value - DateTime.Now;
                return remainingDays.TotalDays < 30;
            }
            return false;
        }
        public override string ToString()
        {
            string productInfo = $"Mã hàng: {Code}, Tên hàng: {Name}, Giá tiền: {Price}, Ngày sản xuất: {ManufactureDate.ToString("yyyy-MM-dd")}";
            if (ExpiryDate.HasValue)
            {
                productInfo += $", Ngày hết hạn: {ExpiryDate.Value.ToString("yyyy-MM-dd")}";
            }
            return productInfo;
        }
    }

}
