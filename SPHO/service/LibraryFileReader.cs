using SPHO.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SPHO.service
{
    public sealed class LibraryFileReader
    {
        public List<string> GetBooks(string tenThuVien)
        {
            try
            {
                List<string> result = new List<string>();
                var content = ReadFile();
                var lines = content.Split('.');
                foreach (var line in lines)
                {
                    var info = line.Split('-');
                    if (!info[0].Contains(tenThuVien))
                        continue;
                    var books = info[1];
                    result = books.Split(',').ToList();
                    break;
                }
                return result;
            }
            catch (LibraryException libEx) 
            {
                
            }
            catch (System.Exception ex)
            {

                throw;
            }
          

        }
        string ReadFile()
        {
            string filePath = "C://data.txt";
            if (filePath.StartsWith("C"))
                throw new LibraryException("Sai folder, bot xam2 lon6");
            string content = File.ReadAllText(filePath);
            return content;
        }
    }
}
