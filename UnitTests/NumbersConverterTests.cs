namespace UnitTests
{
    using NumbersToWords.NumbersConversion;
    using NUnit.Framework;

    [TestFixture]
    public class NumbersConverterTests
    {
        [TestCase(10ul, "М", "П", ExpectedResult = "десяти")]
        [TestCase(10ul, "м", "п", ExpectedResult = "десяти")]
        [TestCase(0ul, "М", "Д", ExpectedResult = "нолю")]
        [TestCase(1ul, "М", "И", ExpectedResult = "один")]
        [TestCase(1ul, "М", "Р", ExpectedResult = "одного")]
        [TestCase(1ul, "М", "Д", ExpectedResult = "одному")]
        [TestCase(1ul, "М", "В", ExpectedResult = "один")]
        [TestCase(1ul, "М", "Т", ExpectedResult = "одним")]
        [TestCase(1ul, "М", "П", ExpectedResult = "одном")]
        [TestCase(1ul, "Ж", "И", ExpectedResult = "одна")]
        [TestCase(1ul, "Ж", "Р", ExpectedResult = "одной")]
        [TestCase(1ul, "Ж", "Д", ExpectedResult = "одной")]
        [TestCase(1ul, "Ж", "В", ExpectedResult = "одну")]
        [TestCase(1ul, "Ж", "Т", ExpectedResult = "одной")]
        [TestCase(1ul, "Ж", "П", ExpectedResult = "одной")]
        [TestCase(1ul, "С", "И", ExpectedResult = "одно")]
        [TestCase(1ul, "С", "Р", ExpectedResult = "одного")]
        [TestCase(1ul, "С", "Д", ExpectedResult = "одному")]
        [TestCase(1ul, "С", "В", ExpectedResult = "одно")]
        [TestCase(1ul, "С", "Т", ExpectedResult = "одним")]
        [TestCase(1ul, "С", "П", ExpectedResult = "одном")]
        [TestCase(2ul, "М", "И", ExpectedResult = "два")]
        [TestCase(2ul, "Ж", "И", ExpectedResult = "две")]
        [TestCase(2ul, "С", "И", ExpectedResult = "два")]
        [TestCase(3ul, "М", "И", ExpectedResult = "три")]
        [TestCase(3ul, "Ж", "И", ExpectedResult = "три")]
        [TestCase(3ul, "С", "И", ExpectedResult = "три")]
        [TestCase(19ul, "М", "Т", ExpectedResult = "девятнадцатью")]
        [TestCase(20ul, "М", "Т", ExpectedResult = "двадцатью")]
        [TestCase(21ul, "М", "Т", ExpectedResult = "двадцатью одним")]
        [TestCase(100ul, "М", "Т", ExpectedResult = "ста")]
        [TestCase(101ul, "М", "Т", ExpectedResult = "ста одним")]
        [TestCase(120ul, "М", "Т", ExpectedResult = "ста двадцатью")]
        [TestCase(121ul, "М", "Т", ExpectedResult = "ста двадцатью одним")]
        public string SumPropTest(ulong nSum, string sGender, string sCase)
        {
            var converter = new NumbersConverter();

            return converter.SumProp(nSum, sGender, sCase);
        }
    }
}
