namespace NumbersToWords
{
    using NumbersToWords.NumbersConversion;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var converter = new NumbersConverter();

            Console.WriteLine(converter.SumProp(31, "М", "Р"));
            Console.WriteLine(converter.SumProp(22, "С", "Т"));
            Console.WriteLine(converter.SumProp(154323, "М", "И"));
            Console.WriteLine(converter.SumProp(154323, "М", "Т"));
        }
    }
}
