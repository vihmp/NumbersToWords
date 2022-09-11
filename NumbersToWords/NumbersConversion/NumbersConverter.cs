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

            ulong ones = nSum % 1000;
            nSum /= 1000;
            ulong thousands = nSum % 1000;
            nSum /= 1000;
            ulong millions = nSum % 1000;
            nSum /= 1000;
            ulong billions = nSum;

            var result = new StringBuilder();

            if (ones > 0)
            {
                result.Append(ConvertOnes(ones, gender, @case));
            }

            if (thousands > 0)
            {
                if (result.Length > 0)
                {
                    result.Insert(0, " ");
                }

                result.Insert(0, ConvertThousands(thousands, @case));
            }

            if (millions > 0)
            {
                if (result.Length > 0)
                {
                    result.Insert(0, " ");
                }

                result.Insert(0, ConvertMillions(millions, @case));
            }

            if (billions > 0)
            {
                if (result.Length > 0)
                {
                    result.Insert(0, " ");
                }

                result.Insert(0, ConvertBillions(billions, @case));
            }

            return result.ToString();
        }

        /// <summary>
        /// Converts numbers from 1 to 999 to words using specified gender and case
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="gender">Gender</param>
        /// <param name="case">Case</param>
        /// <returns>Converted number</returns>
        private string ConvertOnes(ulong number, Genders gender, Cases @case)
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
        /// Converts specified number of thousands to words using specified case
        /// </summary>
        /// <param name="number">Number of thousands</param>
        /// <param name="case">Case</param>
        /// <returns>Converted number</returns>
        private string ConvertThousands(ulong number, Cases @case)
        {
            var thousandGrammaticalNumber = 
                GetGrammaticalNumber(number, @case, Genders.Feminine);
            var thousandCase = 
                GetCase(number, @case, Genders.Feminine);

            var result = new StringBuilder();

            result.Append(ConvertOnes(number, Genders.Feminine, @case));
            result.Append(" ");
            result.Append(ConversionTables.Thousand[thousandGrammaticalNumber][thousandCase]);

            return result.ToString();
        }

        /// <summary>
        /// Converts specified number of millions to words using specified case
        /// </summary>
        /// <param name="number">Number of millions</param>
        /// <param name="case">Case</param>
        /// <returns>Converted number</returns>
        private string ConvertMillions(ulong number, Cases @case)
        {
            var millionGrammaticalNumber = 
                GetGrammaticalNumber(number, @case, Genders.Masculine);
            var millionCase = 
                GetCase(number, @case, Genders.Masculine);

            var result = new StringBuilder();

            result.Append(ConvertOnes(number, Genders.Masculine, @case));
            result.Append(" ");
            result.Append(ConversionTables.Million[millionGrammaticalNumber][millionCase]);

            return result.ToString();
        }

        /// <summary>
        /// Converts specified number of billions to words using specified case
        /// </summary>
        /// <param name="number">Number of billions</param>
        /// <param name="case">Case</param>
        /// <returns>Converted number</returns>
        private string ConvertBillions(ulong number, Cases @case)
        {
            var billionGrammaticalNumber = 
                GetGrammaticalNumber(number, @case, Genders.Masculine);
            var billionCase = 
                GetCase(number, @case, Genders.Masculine);

            var result = new StringBuilder();

            result.Append(ConvertOnes(number, Genders.Masculine, @case));
            result.Append(" ");
            result.Append(ConversionTables.Billion[billionGrammaticalNumber][billionCase]);

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

        /// <summary>
        /// Returns grammatical number of 'thousand'/'million'/'billion' word
        /// following specified number (that is written in specified case)
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="case">Case of converted number</param>
        /// <param name="gender">Gender of 'thousand'/'million'/'billion' word</param>
        /// <returns>Grammatical number</returns>
        private GrammaticalNumbers GetGrammaticalNumber(ulong number, Cases @case, Genders gender)
        {
            // We suppose that 'number' is greater than zero, so 'hundreds' or 'tens' 
            // should be greater than zero if 'ones' = 0
            var (_, _, ones) = SplitNumber(number);

            if (gender == Genders.Feminine)
            {
                return (ones == 1) ?
                    GrammaticalNumbers.Singular :
                    GrammaticalNumbers.Plural;
            }
            else
            {
                switch (ones)
                {
                    case 1:
                        return GrammaticalNumbers.Singular;
                    case 2:
                    case 3:
                    case 4:
                        if ((@case == Cases.Nominative) ||
                            (@case == Cases.Accusative))
                        {
                            return GrammaticalNumbers.Singular;
                        }
                        else
                        {
                            return GrammaticalNumbers.Plural;
                        }
                    default:
                        return GrammaticalNumbers.Plural;
                }
            }
            
        }

        /// <summary>
        /// Returns case of 'thousand'/'million'/'billion' word following specified 
        /// number (that is written in specified case)
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="case">Case of converted number</param>
        /// <returns>Case</returns>
        private Cases GetCase(ulong number, Cases @case, Genders gender)
        {
            // We suppose that 'number' is greater than zero, so 'hundreds' or 'tens' 
            // should be greater than zero if 'ones' = 0
            var (_, _, ones) = SplitNumber(number);

            if (gender == Genders.Feminine)
            {
                switch (ones)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        return @case;
                    default:
                        if ((@case == Cases.Nominative) ||
                            (@case == Cases.Accusative))
                        {
                            return Cases.Genitive;
                        }
                        else
                        {
                            return @case;
                        }
                }
            }
            else
            {
                if (ones == 1)
                {
                    return @case;
                }
                else
                {
                    if ((@case == Cases.Nominative) ||
                        (@case == Cases.Accusative))
                    {
                        return Cases.Genitive;
                    }
                    else
                    {
                        return @case;
                    }
                }
            }
        }
    }
}
