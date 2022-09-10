namespace NumbersToWords.NumbersConversion
{
    using System.Collections.Generic;

    /// <summary>
    /// Collection of tables describing conversion of numbers to words
    /// </summary>
    public static class ConversionTables
    {
        /// <summary>
        /// Conversion table for numbers that are not inflected for gender
        /// </summary>
        public static Dictionary<ulong, Dictionary<Cases, string>> NonGenderedNumbers { get; } =
            new Dictionary<ulong, Dictionary<Cases, string>>()
        {
            [0] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "ноль",
                [Cases.Genitive] =      "ноля",
                [Cases.Dative] =        "нолю",
                [Cases.Accusative] =    "ноль",
                [Cases.Instrumental] =  "нолем",
                [Cases.Prepositional] = "ноле"
            },
            [3] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "три",
                [Cases.Genitive] =      "трех",
                [Cases.Dative] =        "трем",
                [Cases.Accusative] =    "три",
                [Cases.Instrumental] =  "тремя",
                [Cases.Prepositional] = "трех"
            },
            [4] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "четыре",
                [Cases.Genitive] =      "четырех",
                [Cases.Dative] =        "четырем",
                [Cases.Accusative] =    "четыре",
                [Cases.Instrumental] =  "четырьмя",
                [Cases.Prepositional] = "четырех"
            },
            [5] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "пять",
                [Cases.Genitive] =      "пяти",
                [Cases.Dative] =        "пяти",
                [Cases.Accusative] =    "пять",
                [Cases.Instrumental] =  "пятью",
                [Cases.Prepositional] = "пяти"
            },
            [6] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "шесть",
                [Cases.Genitive] =      "шести",
                [Cases.Dative] =        "шести",
                [Cases.Accusative] =    "шесть",
                [Cases.Instrumental] =  "шестью",
                [Cases.Prepositional] = "шести"
            },
            [7] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "семь",
                [Cases.Genitive] =      "семи",
                [Cases.Dative] =        "семи",
                [Cases.Accusative] =    "семь",
                [Cases.Instrumental] =  "семью",
                [Cases.Prepositional] = "семи"
            },
            [8] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "восемь",
                [Cases.Genitive] =      "восьми",
                [Cases.Dative] =        "восьми",
                [Cases.Accusative] =    "восемь",
                [Cases.Instrumental] =  "восемью",
                [Cases.Prepositional] = "восьми"
            },
            [9] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "девять",
                [Cases.Genitive] =      "девяти",
                [Cases.Dative] =        "девяти",
                [Cases.Accusative] =    "девять",
                [Cases.Instrumental] =  "девятью",
                [Cases.Prepositional] = "девяти"
            },
            [10] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "десять",
                [Cases.Genitive] =      "десяти",
                [Cases.Dative] =        "десяти",
                [Cases.Accusative] =    "десять",
                [Cases.Instrumental] =  "десятью",
                [Cases.Prepositional] = "десяти"
            },
            [11] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "одиннадцать",
                [Cases.Genitive] =      "одиннадцати",
                [Cases.Dative] =        "одиннадцати",
                [Cases.Accusative] =    "одиннадцать",
                [Cases.Instrumental] =  "одиннадцатью",
                [Cases.Prepositional] = "одиннадцати"
            },
            [12] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "двенадцать",
                [Cases.Genitive] =      "двенадцати",
                [Cases.Dative] =        "двенадцати",
                [Cases.Accusative] =    "двенадцать",
                [Cases.Instrumental] =  "двенадцатью",
                [Cases.Prepositional] = "двенадцати"
            },
            [13] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "тринадцать",
                [Cases.Genitive] =      "тринадцати",
                [Cases.Dative] =        "тринадцати",
                [Cases.Accusative] =    "тринадцать",
                [Cases.Instrumental] =  "тринадцатью",
                [Cases.Prepositional] = "тринадцати"
            },
            [14] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "четырнадцать",
                [Cases.Genitive] =      "четырнадцати",
                [Cases.Dative] =        "четырнадцати",
                [Cases.Accusative] =    "четырнадцать",
                [Cases.Instrumental] =  "четырнадцатью",
                [Cases.Prepositional] = "четырнадцати"
            },
            [15] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "пятнадцать",
                [Cases.Genitive] =      "пятнадцати",
                [Cases.Dative] =        "пятнадцати",
                [Cases.Accusative] =    "пятнадцать",
                [Cases.Instrumental] =  "пятнадцатью",
                [Cases.Prepositional] = "пятнадцати"
            },
            [16] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "шестнадцать",
                [Cases.Genitive] =      "шестнадцати",
                [Cases.Dative] =        "шестнадцати",
                [Cases.Accusative] =    "шестнадцать",
                [Cases.Instrumental] =  "шестнадцатью",
                [Cases.Prepositional] = "шестнадцати"
            },
            [17] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "семнадцать",
                [Cases.Genitive] =      "семнадцати",
                [Cases.Dative] =        "семнадцати",
                [Cases.Accusative] =    "семнадцать",
                [Cases.Instrumental] =  "семнадцатью",
                [Cases.Prepositional] = "семнадцати"
            },
            [18] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "восемнадцать",
                [Cases.Genitive] =      "восемнадцати",
                [Cases.Dative] =        "восемнадцати",
                [Cases.Accusative] =    "восемнадцать",
                [Cases.Instrumental] =  "восемнадцатью",
                [Cases.Prepositional] = "восемнадцати"
            },
            [19] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "девятнадцать",
                [Cases.Genitive] =      "девятнадцати",
                [Cases.Dative] =        "девятнадцати",
                [Cases.Accusative] =    "девятнадцать",
                [Cases.Instrumental] =  "девятнадцатью",
                [Cases.Prepositional] = "девятнадцати"
            },
            [20] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "двадцать",
                [Cases.Genitive] =      "двадцати",
                [Cases.Dative] =        "двадцати",
                [Cases.Accusative] =    "двадцать",
                [Cases.Instrumental] =  "двадцатью",
                [Cases.Prepositional] = "двадцати"
            },
            [30] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "тридцать",
                [Cases.Genitive] =      "тридцати",
                [Cases.Dative] =        "тридцати",
                [Cases.Accusative] =    "тридцать",
                [Cases.Instrumental] =  "тридцатью",
                [Cases.Prepositional] = "тридцати"
            },
            [40] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "сорок",
                [Cases.Genitive] =      "сорока",
                [Cases.Dative] =        "сорока",
                [Cases.Accusative] =    "сорок",
                [Cases.Instrumental] =  "сорока",
                [Cases.Prepositional] = "сорока"
            },
            [50] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "пятьдесят",
                [Cases.Genitive] =      "пятидесяти",
                [Cases.Dative] =        "пятидесяти",
                [Cases.Accusative] =    "пятьдесят",
                [Cases.Instrumental] =  "пятьюдесятью",
                [Cases.Prepositional] = "пятидесяти"
            },
            [60] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "шестьдесят",
                [Cases.Genitive] =      "шестидесяти",
                [Cases.Dative] =        "шестидесяти",
                [Cases.Accusative] =    "шестьдесят",
                [Cases.Instrumental] =  "шестьюдесятью",
                [Cases.Prepositional] = "шестидесяти"
            },
            [70] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "семьдесят",
                [Cases.Genitive] =      "семидесяти",
                [Cases.Dative] =        "семидесяти",
                [Cases.Accusative] =    "семьдесят",
                [Cases.Instrumental] =  "семьюдесятью",
                [Cases.Prepositional] = "семидесяти"
            },
            [80] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "восемьдесят",
                [Cases.Genitive] =      "восьмидесяти",
                [Cases.Dative] =        "восьмидесяти",
                [Cases.Accusative] =    "восемьдесят",
                [Cases.Instrumental] =  "восемьюдесятью",
                [Cases.Prepositional] = "восьмидесяти"
            },
            [90] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "девяносто",
                [Cases.Genitive] =      "девяноста",
                [Cases.Dative] =        "девяноста",
                [Cases.Accusative] =    "девяносто",
                [Cases.Instrumental] =  "девяноста",
                [Cases.Prepositional] = "девяноста"
            },
            [100] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "сто",
                [Cases.Genitive] =      "ста",
                [Cases.Dative] =        "ста",
                [Cases.Accusative] =    "сто",
                [Cases.Instrumental] =  "ста",
                [Cases.Prepositional] = "ста"
            },
            [200] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "двести",
                [Cases.Genitive] =      "двухсот",
                [Cases.Dative] =        "двумстам",
                [Cases.Accusative] =    "двести",
                [Cases.Instrumental] =  "двумястами",
                [Cases.Prepositional] = "двухстах"
            },
            [300] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "триста",
                [Cases.Genitive] =      "трехсот",
                [Cases.Dative] =        "тремстам",
                [Cases.Accusative] =    "триста",
                [Cases.Instrumental] =  "тремястами",
                [Cases.Prepositional] = "трехстах"
            },
            [400] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "четыреста",
                [Cases.Genitive] =      "четырехсот",
                [Cases.Dative] =        "четыремстам",
                [Cases.Accusative] =    "четыреста",
                [Cases.Instrumental] =  "четырьмястами",
                [Cases.Prepositional] = "четырехстах"
            },
            [500] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "пятьсот",
                [Cases.Genitive] =      "пятисот",
                [Cases.Dative] =        "пятистам",
                [Cases.Accusative] =    "пятьсот",
                [Cases.Instrumental] =  "пятьюстами",
                [Cases.Prepositional] = "пятистах"
            },
            [600] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "шестьсот",
                [Cases.Genitive] =      "шестисот",
                [Cases.Dative] =        "шестистам",
                [Cases.Accusative] =    "шестьсот",
                [Cases.Instrumental] =  "шестьюстами",
                [Cases.Prepositional] = "шестистах"
            },
            [700] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "семьсот",
                [Cases.Genitive] =      "семисот",
                [Cases.Dative] =        "семистам",
                [Cases.Accusative] =    "семьсот",
                [Cases.Instrumental] =  "семьюстами",
                [Cases.Prepositional] = "семистах"
            },
            [800] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "восемьсот",
                [Cases.Genitive] =      "восьмисот",
                [Cases.Dative] =        "восьмистам",
                [Cases.Accusative] =    "восемьсот",
                [Cases.Instrumental] =  "восемьюстами",
                [Cases.Prepositional] = "восьмистах"
            },
            [900] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "девятьсот",
                [Cases.Genitive] =      "девятисот",
                [Cases.Dative] =        "девятистам",
                [Cases.Accusative] =    "девятьсот",
                [Cases.Instrumental] =  "девятьюстами",
                [Cases.Prepositional] = "девятистах"
            }
        };

        /// <summary>
        /// Conversion table for numbers that are inflected for gender
        /// </summary>
        public static Dictionary<ulong, Dictionary<Genders, Dictionary<Cases, string>>> GenderedNumbers { get; } =
            new Dictionary<ulong, Dictionary<Genders, Dictionary<Cases, string>>>()
        {
            [1] = new Dictionary<Genders, Dictionary<Cases, string>>()
            {
                [Genders.Masculine] = new Dictionary<Cases, string>()
                {
                    [Cases.Nominative] =    "один",
                    [Cases.Genitive] =      "одного",
                    [Cases.Dative] =        "одному",
                    [Cases.Accusative] =    "один",
                    [Cases.Instrumental] =  "одним",
                    [Cases.Prepositional] = "одном"
                },
                [Genders.Feminine] = new Dictionary<Cases, string>()
                {
                    [Cases.Nominative] =    "одна",
                    [Cases.Genitive] =      "одной",
                    [Cases.Dative] =        "одной",
                    [Cases.Accusative] =    "одну",
                    [Cases.Instrumental] =  "одной",
                    [Cases.Prepositional] = "одной"
                },
                [Genders.Neuter] = new Dictionary<Cases, string>()
                {
                    [Cases.Nominative] =    "одно",
                    [Cases.Genitive] =      "одного",
                    [Cases.Dative] =        "одному",
                    [Cases.Accusative] =    "одно",
                    [Cases.Instrumental] =  "одним",
                    [Cases.Prepositional] = "одном"
                }
            },
            [2] = new Dictionary<Genders, Dictionary<Cases, string>>()
            {
                [Genders.Masculine] = new Dictionary<Cases, string>()
                {
                    [Cases.Nominative] =    "два",
                    [Cases.Genitive] =      "двух",
                    [Cases.Dative] =        "двум",
                    [Cases.Accusative] =    "два",
                    [Cases.Instrumental] =  "двумя",
                    [Cases.Prepositional] = "двух"
                },
                [Genders.Feminine] = new Dictionary<Cases, string>()
                {
                    [Cases.Nominative] =    "две",
                    [Cases.Genitive] =      "двух",
                    [Cases.Dative] =        "двум",
                    [Cases.Accusative] =    "две",
                    [Cases.Instrumental] =  "двумя",
                    [Cases.Prepositional] = "двух"
                },
                [Genders.Neuter] = new Dictionary<Cases, string>()
                {
                    [Cases.Nominative] =    "два",
                    [Cases.Genitive] =      "двух",
                    [Cases.Dative] =        "двум",
                    [Cases.Accusative] =    "два",
                    [Cases.Instrumental] =  "двумя",
                    [Cases.Prepositional] = "двух"
                }
            }
        };

        /// <summary>
        /// Conversion table for one thousand
        /// </summary>
        public static Dictionary<GrammaticalNumbers, Dictionary<Cases, string>> Thousand =
            new Dictionary<GrammaticalNumbers, Dictionary<Cases, string>>()
        {
            [GrammaticalNumbers.Singular] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "тысяча",
                [Cases.Genitive] =      "тысячи",
                [Cases.Dative] =        "тысяче",
                [Cases.Accusative] =    "тысячу",
                [Cases.Instrumental] =  "тысячей",
                [Cases.Prepositional] = "тысяче"
            },
            [GrammaticalNumbers.Plural] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "тысячи",
                [Cases.Genitive] =      "тысяч",
                [Cases.Dative] =        "тысячам",
                [Cases.Accusative] =    "тысячи",
                [Cases.Instrumental] =  "тысячами",
                [Cases.Prepositional] = "тысячах"
            }
        };

        /// <summary>
        /// Conversion table for one million
        /// </summary>
        public static Dictionary<GrammaticalNumbers, Dictionary<Cases, string>> Million =
            new Dictionary<GrammaticalNumbers, Dictionary<Cases, string>>()
        {
            [GrammaticalNumbers.Singular] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "миллион",
                [Cases.Genitive] =      "миллиона",
                [Cases.Dative] =        "миллиону",
                [Cases.Accusative] =    "миллион",
                [Cases.Instrumental] =  "миллионом",
                [Cases.Prepositional] = "миллионе"
            },
            [GrammaticalNumbers.Plural] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "миллионы",
                [Cases.Genitive] =      "миллионов",
                [Cases.Dative] =        "миллионам",
                [Cases.Accusative] =    "миллионы",
                [Cases.Instrumental] =  "миллионами",
                [Cases.Prepositional] = "миллионах"
            }
        };

        /// <summary>
        /// Conversion table for one billion
        /// </summary>
        public static Dictionary<GrammaticalNumbers, Dictionary<Cases, string>> Billion =
            new Dictionary<GrammaticalNumbers, Dictionary<Cases, string>>()
        {
            [GrammaticalNumbers.Singular] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "миллиард",
                [Cases.Genitive] =      "миллиарда",
                [Cases.Dative] =        "миллиарду",
                [Cases.Accusative] =    "миллиард",
                [Cases.Instrumental] =  "миллиардом",
                [Cases.Prepositional] = "миллиарде"
            },
            [GrammaticalNumbers.Plural] = new Dictionary<Cases, string>()
            {
                [Cases.Nominative] =    "миллиарды",
                [Cases.Genitive] =      "миллиардов",
                [Cases.Dative] =        "миллиардам",
                [Cases.Accusative] =    "миллиарды",
                [Cases.Instrumental] =  "миллиардами",
                [Cases.Prepositional] = "миллиардах"
            }
        };
    }
}