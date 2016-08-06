using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt;
            string date = "24-01-2013";
            string format = "dd/MM/yyyy";
            if (DateTime.TryParseExact(date,
                                        format,
                                        CultureInfo.InvariantCulture,
                                        DateTimeStyles.None,
                out dt))
            {
                Console.WriteLine(dt.ToShortDateString());
            }
            else
            {
                Console.WriteLine("String is not formated to date");
            }

            Console.ReadLine();
        }
    }
}
