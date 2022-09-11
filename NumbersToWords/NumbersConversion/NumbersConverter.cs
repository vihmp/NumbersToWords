namespace NumbersToWords.NumbersConversion
{
    using System;
    using System.Text;

    /// <summary>
    /// Converter of numbers to words
    /// </summary>
    public class NumbersConverter
    {
        /// <summary>
        /// Converts numbers to words using specified gender and case
        /// </summary>
        /// <param name="nSum">Number</param>
        /// <param name="sGender">Gender</param>
        /// <param name="sCase">Case</param>
        /// <returns>Converted number</returns>
        public string SumProp(ulong nSum, string sGender, string sCase)
        {
            if (nSum > 999999999999ul)
            {
                throw new ArgumentException(nameof(nSum));
            }

            var @case = ParseCase(sCase);
            var gender = ParseGender(sGender);

            if (nSum == 0)
            {
                return ConversionTables.NonGenderedNumbers[0][@case];
            }

            var result = new StringBuilder();

            result.Append(ConvertNumber(nSum, gender, @case));

            return result.ToString();
        }

        /// <summary>
        /// Converts string describing case to enumeration value
        /// </summary>
        /// <param name="caseString">String describing case</param>
        /// <returns>Enumeration value</returns>
        private Cases ParseCase(string caseString)
        {
            switch (caseString.ToLower())
            {
                case "и":
                    return Cases.Nominative;
                case "р":
                    return Cases.Genitive;
                case "д":
                    return Cases.Dative;
                case "в":
                    return Cases.Accusative;
                case "т":
                    return Cases.Instrumental;
                case "п":
                    return Cases.Prepositional;
                default:
                    throw new ArgumentException(nameof(caseString));
            }
        }

        /// <summary>
        /// Converts string describing gender to enumeration value
        /// </summary>
        /// <param name="genderString">String describing gender</param>
        /// <returns>Enumeration value</returns>
        private Genders ParseGender(string genderString)
        {
            switch (genderString.ToLower())
            {
                case "м":
                    return Genders.Masculine;
                case "ж":
                    return Genders.Feminine;
                case "с":
                    return Genders.Neuter;
                default:
                    throw new ArgumentException(nameof(genderString));
            }
        }

        /// <summary>
        /// Converts numbers from 1 to 999 to words using specified gender and case
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="gender">Gender</param>
        /// <param name="case">Case</param>
        /// <returns>Converted number</returns>
        private string ConvertNumber(ulong number, Genders gender, Cases @case)
        {
            var result = new StringBuilder();

            var (hundreds, tens, ones) = SplitNumber(number);

            if (ones > 0)
            {
                result.Append(IsGenderedNumber(ones) ?
                    ConversionTables.GenderedNumbers[ones][gender][@case] :
                    ConversionTables.NonGenderedNumbers[ones][@case]);
            }

            if (tens > 0)
            {
                if (result.Length > 0)
                {
                    result.Insert(0, " ");
                }

                result.Insert(0, ConversionTables.NonGenderedNumbers[tens][@case]);
            }

            if (hundreds > 0)
            {
                if (result.Length > 0)
                {
                    result.Insert(0, " ");
                }

                result.Insert(0, ConversionTables.NonGenderedNumbers[hundreds][@case]);
            }

            return result.ToString();
        }

        /// <summary>
        /// Splits number from 1 to 999 into hundreds, tens and ones
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private (ulong Hundreds, ulong Tens, ulong Ones) SplitNumber(ulong number)
        {
            ulong ones;
            ulong tens;

            if (number % 100 > 19)
            {
                ones = number % 10;
                tens = (number % 100) - ones;
            }
            else
            {
                ones = number % 100;
                tens = 0;
            }

            ulong hundreds = number - tens - ones;

            return (hundreds, tens, ones);
        }

        /// <summary>
        /// Returns 'true' if specified number is gendered
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>'true' if specified number is gendered</returns>
        private bool IsGenderedNumber(ulong number)
        {
            return (number == 1) || (number == 2);
        }
    }
}
