using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookWinform.Models
{
    public class Authors
    {
        public string ID { get; set; }
        public string AName { get; set; }
        public string Country { get; set; }

        public List<Books> Books { get; set; } // Một tác giả có nhiều cuốn sách



        public Authors() { }
        public Authors(string id, string aname, string country,List<Books> books)
        {
            ID = id;
            AName = aname;
            Country = country;
            Books = books;
        }
        ~Authors() { }
        public override string ToString()
        {
            return $"ID tác giả: {this.ID},Tên tác giả : {this.AName}, Quốc gia : {this.Country}";
        }
        
    }
}
