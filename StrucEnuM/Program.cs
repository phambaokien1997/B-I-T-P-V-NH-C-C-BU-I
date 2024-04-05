using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrucEnuM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime myDatetime = new DateTime();
            //var dateNow = DateTime.Now;
            //Console.WriteLine("myDatetime= " + myDatetime);
            //Console.WriteLine("dateNow= " + dateNow);

            //var previousDay = DateTime.Now.AddDays(-1);
            //Console.WriteLine(previousDay);

            //var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //Console.WriteLine(firstDayOfMonth);
            //var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            //var dayInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            //Console.WriteLine(lastDayOfMonth);
            //Console.WriteLine(dayInMonth);
            //var timeSpan = new TimeSpan(1,1,0);
            //var nextDayTimeSpan = DateTime.Now.Add(timeSpan);
            //Console.WriteLine(nextDayTimeSpan);
            Console.WriteLine("nhap ngay sinhvao day");
            string input = Console.ReadLine();
            DateTime date;
            if(!DateTime.TryParseExact(input, "dd/MM/yyyy",new)
            TimeSpan thoiGian = DateTime.Now - DateTime.Now.Add(-1);
            int soNgay = thoiGian.Days;

        }
    }
}
