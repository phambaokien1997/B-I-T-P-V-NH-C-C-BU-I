using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNBUOI13
{
    public class Authors
    {
        //public string ID { get; set; } 
        //public string AName { get; set; }
        //public string Country { get; set; }

        //public List<Books> Books { get; set; } // Một tác giả có nhiều cuốn sách

        private string ID;
        private string aName;
        private string country;
        private List<Books> books = new List<Books>();
        public string ID1 { get => ID; set => ID = value; }
        public string AName { get => aName; set => aName = value; }
        public string Country { get => country; set => country = value; }
        public List<Books> Books { get => books; set => books = value; }

        public Authors() { }
        public Authors(string id, string aname, string country,List<Books> books)
        {
            this.ID = id;
            this.AName = aname;
            this.Country = country;
            this.Books = books;
        }
        public override string ToString()
        {
            return $"ID tác giả: {this.ID},Tên tác giả : {this.AName}, Quốc gia : {this.Country}";
        }
        
    }
}
