using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPHO.service
{
    public class Class1
    {
        private string Code = "N-";
        private string name;

        public string Name { get => name.Replace(Code, ""); set => name = Code + value; }
    }
}
