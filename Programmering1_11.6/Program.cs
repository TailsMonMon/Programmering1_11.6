using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_11._6 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Skriv en procent i decimal form: ");
            decimal precentageDecimal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(ToPercentage(precentageDecimal));
            Console.ReadLine();
        }

        //      DECIMAL TO PERCENT
        static string ToPercentage(decimal percentageDecimal) {
            decimal percentageCalculate = percentageDecimal * 100;
            string percentage = "Procenten är " + percentageCalculate;
            return percentage;
        }
    }
}
