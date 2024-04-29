using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPHO.service
{
    class LibraryManager : LibraryFileReader
    {
        public Dictionary<string, List<string>> Libraries { get; set; } = new Dictionary<string, List<string>>
        {
            { "thu vien da nang", new List<string> { "lam di", "tat den" } },
            { "thu vien quang nam", new List<string> { "lam di", "tat den" } },
            { "thu vien hue", new List<string> { "lam di", "tat den" } },
            { "thu vien sg", new List<string> { "lam di", "tat den" } },
        };
        public List<string> GetBook(string tenThuVien)
        {
            //List<string> result = null;
            //foreach (var item in Libraries)
            //{
            //    if (tenThuVien == item.Key)
            //    {
            //        result = item.Value;
            //        break;
            //    }
            //}
            //if (result == null)
            //    throw new Exception("Ko tim thay thu vien");
            //return result;
            if (!Libraries.TryGetValue(tenThuVien, out List<string> result))
            {
                return null;
            }
            return result;
        }

    }
}
