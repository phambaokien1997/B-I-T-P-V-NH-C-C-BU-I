using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN7_Quanly
{
    public class Book
    {
        //khởi tạo biến
        // thuộc tính Title, Author, ISBN, Price
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        //Constructor 
        public Book(string title, string author, string isbn, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            this.Price = price;
        }
        //Override phương thức ToString để hiển thị thông tin của cuốn sách
        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Price: {Price}";
        }
        

    }
}
