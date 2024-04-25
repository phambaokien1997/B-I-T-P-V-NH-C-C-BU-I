using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN9._2
{
    class Validator
    {
        public static bool IsValidName(string name)
        {
            // Kiểm tra xem tên có rỗng không
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            // Kiểm tra xem tên có chứa ký tự số không
            if (name.Any(char.IsDigit))
            {
                return false;
            }

            // Tên hợp lệ
            return true;
        }

        public static bool IsValidDate(string dateString)
        {
            // Kiểm tra xem chuỗi ngày có đúng định dạng không
            DateTime date;
            if (!DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                return false;
            }

            // Ngày hợp lệ
            return true;
        }

        public static bool IsValidFee(string feeString)
        {
            // Kiểm tra xem chuỗi học phí có đúng định dạng số không
            double fee;
            if (!double.TryParse(feeString, out fee))
            {
                return false;
            }

            // Học phí hợp lệ
            return true;
        }
    }
}
