using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter culture name: ");
            string cultureName = Console.ReadLine();
            Console.Write("Enter culture name for contrast: ");
            string contrastCultureName = Console.ReadLine();
            Console.WriteLine();
            if ((cultureName == "en" || cultureName == "ru" || cultureName == "invariant" || cultureName == "inv"))
            {
                CultureContrast(cultureName);
                CultureContrast(contrastCultureName);
                NumberFormat(cultureName, contrastCultureName);
            }
            else
            {
                Console.WriteLine("Wrong culture name!");
            }
            //Console.Write("Enter number: ");
            //double number = double.Parse(Console.ReadLine());

            Console.ReadKey();
        }
        static void CultureContrast(string cultureName)
        {
            DateTime thisDate = new DateTime(2018, 3, 6, 17, 37, 0);
            switch (cultureName)
            {
                case "en":
                    {
                        Console.Write("English format: ");
                        Console.WriteLine(thisDate.ToString("f", CultureInfo.CreateSpecificCulture("en")));
                        Console.WriteLine();
                        break;
                    }
                case "ru":
                    {
                        Console.Write("Russian format: ");
                        Console.WriteLine(thisDate.ToString("f", CultureInfo.CreateSpecificCulture("ru")));
                        Console.WriteLine();
                        break;
                    }
                case "invariant":
                    {
                        Console.Write("Invariant format: ");
                        Console.WriteLine(thisDate.ToString("f", CultureInfo.CreateSpecificCulture("")));
                        Console.WriteLine();
                        break;
                    }
            }
        }
        static void NumberFormat(string culture1, string culture2)
        {
            var culture3 = new CultureInfo(culture1);
            var culture4 = new CultureInfo(culture1);
            Console.WriteLine("Currency format:\t{0}\t\t\t{1}", culture3.NumberFormat.CurrencySymbol, culture4.NumberFormat.CurrencySymbol);
            Console.WriteLine("Decimal format:\t\t{0}\t\t\t{1}", culture3.NumberFormat.NumberDecimalSeparator, culture4.NumberFormat.NumberDecimalSeparator);
            Console.WriteLine("Group format:\t\t{0}\t\t\t{1}", culture3.NumberFormat.NumberGroupSeparator, culture4.NumberFormat.NumberGroupSeparator);
        }
    }
}
