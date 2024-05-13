using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using EbookWinform.Models;
using Microsoft.EntityFrameworkCore;


namespace EbookWinform
{
    public class AppDbContext :DbContext
    {
        public DbSet<Authors> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Thiết lập chuỗi kết nối đến cơ sở dữ liệu SQL Server
                string connectionString = "Server=BKS-20240209BOY;Database=BTVN13;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                // Sử dụng SQL Server làm cơ sở dữ liệu
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
