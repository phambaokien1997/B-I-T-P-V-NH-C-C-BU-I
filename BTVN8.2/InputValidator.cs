using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN8._2
{
    public class InputValidator
    {
        public bool ContainsDigits(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsValidInteger(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }
        public bool IsValidDecimal(string input)
        {
            decimal result;
            return decimal.TryParse(input, out result);
        }
        public bool IsValidDate(string input)
        {
            DateTime result;
            return DateTime.TryParse(input, out result);
        }
        public bool IsValidEmail(string input)
        {

            return input.Contains("@");
        }
        public bool ContainsSpecialCharacters(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    return true;
                }
            }
            return false;
        }
        public bool ContainsOnlyDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsNullOrWhitespace(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }
    }
}
