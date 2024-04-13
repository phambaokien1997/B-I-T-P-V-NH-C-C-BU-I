using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BTVN7_Quanly
{
    public class Library
    {
        private List<Book> danhSachBook;

        public Library()
        {
            danhSachBook = new List<Book>();
        }
        public void ThemSach(Book book)
        {
            danhSachBook.Add(book);
        }
        public void timSachTheoTacGia(string author)
        {
            foreach (Book book in danhSachBook)
            {
                if(author.Equals(book.Author))
                {
                    Console.WriteLine(book);
                }    
            }    
        }
        public void timSachTheoISBN(string isbn)
        {
            foreach (Book book in danhSachBook)
            {
                if(isbn.Contains(book.ISBN) == true) 
                {
                    Console.WriteLine(book);
                }
            }    
        }
        public void muonSach(Book book)
        {
            if (danhSachBook.Contains(book))
            {
                danhSachBook.Remove(book);
                Console.WriteLine("Bạn đã mượn được sách");
            }
        }
        public void traSach(Book book)
        {
            danhSachBook.Add(book);
            Console.WriteLine("Bạn đã trả được sách");
        }
        public void displayBooks()
        {
            Console.WriteLine("Danh sách các cuốn sách trong thư viện:");
            foreach (var book in danhSachBook)
            {
                Console.WriteLine(book);
            }
        }



    }
}
