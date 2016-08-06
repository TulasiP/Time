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
            if (DateTime.TryParseExact("24-01-2013",
                                        "dd/MM/yyyy",
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

            Console.ReadKey();
        }
    }
}
