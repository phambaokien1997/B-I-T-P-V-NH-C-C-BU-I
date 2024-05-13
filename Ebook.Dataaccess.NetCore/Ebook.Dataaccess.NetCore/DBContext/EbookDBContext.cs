using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Dataaccess.NetCore.DBContext
{
    public class EbookDBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected EbookDBContext()
        {
        }
    }
}
