using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN8._2
{
    class ClothingProduct : Product
    {
        public override void InputProductInfo()
        {
            Console.Write("Mã hàng: ");
            Code = Console.ReadLine();
            Console.Write("Tên hàng: ");
            Name = Console.ReadLine();
            Console.Write("Giá tiền: ");
            Price = decimal.Parse(Console.ReadLine());
        }
    }
}
