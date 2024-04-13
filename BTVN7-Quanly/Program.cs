using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN7_Quanly
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding=Encoding.UTF8;
            Library danhsach = new Library();
            Book book1 = new Book("yetcndt", "pbk", "2323", 2000);
            Book book2 = new Book("plcgc1lya", "lg1", "2342", 3000);
            danhsach.ThemSach(book1);
            danhsach.ThemSach(book2);
            danhsach.displayBooks();
            danhsach.timSachTheoTacGia("pbk");
            danhsach.timSachTheoISBN("2323");
            danhsach.muonSach(book1);
            danhsach.traSach(book1);
            danhsach.displayBooks();
            Console.ReadKey();
        }  
    }
}
