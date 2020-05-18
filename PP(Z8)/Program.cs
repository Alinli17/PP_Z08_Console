using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PP_Z8_
{
    class Program
    {
        private static IEnumerable<double> GetNumbers(string input)
        {
            var matches = Regex.Matches(input, @"-?\d+(?:\.\d+)?", RegexOptions.Compiled);
            return from Match match in matches select double.Parse(match.Value, CultureInfo.InvariantCulture);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите строчку: ");
            var text = Console.ReadLine();
            var numbers = GetNumbers(text);
            if (numbers.Any())
                Console.Write("Max число в сообщении это: {0}", numbers.Max());
            else
                Console.Write("В сообщении нет числа!");
            Console.ReadKey();
        }
    }
}
