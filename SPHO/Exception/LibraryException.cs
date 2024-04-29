using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPHO.Exceptions
{
    public class LibraryException : Exception
    {
        public LibraryException(string message) : base(message) { }
        public int MyProperty { get; set; }
    }
}
