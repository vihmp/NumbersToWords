namespace NumbersToWords.NumbersConversion
{
    using CasesTable = System.Collections.Generic.Dictionary<Cases, string>;
    using GendersTable = System.Collections.Generic.Dictionary<
        Genders, System.Collections.Generic.Dictionary<Cases, string>>;
    using ConversionTable = System.Collections.Generic.Dictionary<
        int, System.Collections.Generic.Dictionary<
            Genders, System.Collections.Generic.Dictionary<Cases, string>>>;

    /// <summary>
    /// Collection of tables describing conversion of numbers to words
    /// </summary>
    public static class ConversionTables
    {
        /// <summary>
        /// Conversion table for numbers from 0 to 19
        /// </summary>
        public static ConversionTable Digits { get; } = new ConversionTable()
        {
            [0] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "ноль",
                    [Cases.Genitive] =      "ноля",
                    [Cases.Dative] =        "нолю",
                    [Cases.Accusative] =    "ноль",
                    [Cases.Instrumental] =  "нолем",
                    [Cases.Prepositional] = "ноле"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "ноль",
                    [Cases.Genitive] =      "ноля",
                    [Cases.Dative] =        "нолю",
                    [Cases.Accusative] =    "ноль",
                    [Cases.Instrumental] =  "нолем",
                    [Cases.Prepositional] = "ноле"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "ноль",
                    [Cases.Genitive] =      "ноля",
                    [Cases.Dative] =        "нолю",
                    [Cases.Accusative] =    "ноль",
                    [Cases.Instrumental] =  "нолем",
                    [Cases.Prepositional] = "ноле"
                }
            },
            [1] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "один",
                    [Cases.Genitive] =      "одного",
                    [Cases.Dative] =        "одному",
                    [Cases.Accusative] =    "один",
                    [Cases.Instrumental] =  "одним",
                    [Cases.Prepositional] = "одном"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "одна",
                    [Cases.Genitive] =      "одной",
                    [Cases.Dative] =        "одной",
                    [Cases.Accusative] =    "одну",
                    [Cases.Instrumental] =  "одной",
                    [Cases.Prepositional] = "одной"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "одно",
                    [Cases.Genitive] =      "одного",
                    [Cases.Dative] =        "одному",
                    [Cases.Accusative] =    "одно",
                    [Cases.Instrumental] =  "одним",
                    [Cases.Prepositional] = "одном"
                }
            },
            [2] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "два",
                    [Cases.Genitive] =      "двух",
                    [Cases.Dative] =        "двум",
                    [Cases.Accusative] =    "два",
                    [Cases.Instrumental] =  "двумя",
                    [Cases.Prepositional] = "двух"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "две",
                    [Cases.Genitive] =      "двух",
                    [Cases.Dative] =        "двум",
                    [Cases.Accusative] =    "две",
                    [Cases.Instrumental] =  "двумя",
                    [Cases.Prepositional] = "двух"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "два",
                    [Cases.Genitive] =      "двух",
                    [Cases.Dative] =        "двум",
                    [Cases.Accusative] =    "два",
                    [Cases.Instrumental] =  "двумя",
                    [Cases.Prepositional] = "двух"
                }
            },
            [3] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "три",
                    [Cases.Genitive] =      "трех",
                    [Cases.Dative] =        "трем",
                    [Cases.Accusative] =    "три",
                    [Cases.Instrumental] =  "тремя",
                    [Cases.Prepositional] = "трех"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "три",
                    [Cases.Genitive] =      "трех",
                    [Cases.Dative] =        "трем",
                    [Cases.Accusative] =    "три",
                    [Cases.Instrumental] =  "тремя",
                    [Cases.Prepositional] = "трех"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "три",
                    [Cases.Genitive] =      "трех",
                    [Cases.Dative] =        "трем",
                    [Cases.Accusative] =    "три",
                    [Cases.Instrumental] =  "тремя",
                    [Cases.Prepositional] = "трех"
                }
            },
            [4] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "четыре",
                    [Cases.Genitive] =      "четырех",
                    [Cases.Dative] =        "четырем",
                    [Cases.Accusative] =    "четыре",
                    [Cases.Instrumental] =  "четырьмя",
                    [Cases.Prepositional] = "четырех"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "четыре",
                    [Cases.Genitive] =      "четырех",
                    [Cases.Dative] =        "четырем",
                    [Cases.Accusative] =    "четыре",
                    [Cases.Instrumental] =  "четырьмя",
                    [Cases.Prepositional] = "четырех"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "четыре",
                    [Cases.Genitive] =      "четырех",
                    [Cases.Dative] =        "четырем",
                    [Cases.Accusative] =    "четыре",
                    [Cases.Instrumental] =  "четырьмя",
                    [Cases.Prepositional] = "четырех"
                }
            },
            [5] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "пять",
                    [Cases.Genitive] =      "пяти",
                    [Cases.Dative] =        "пяти",
                    [Cases.Accusative] =    "пять",
                    [Cases.Instrumental] =  "пятью",
                    [Cases.Prepositional] = "пяти"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "пять",
                    [Cases.Genitive] =      "пяти",
                    [Cases.Dative] =        "пяти",
                    [Cases.Accusative] =    "пять",
                    [Cases.Instrumental] =  "пятью",
                    [Cases.Prepositional] = "пяти"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "пять",
                    [Cases.Genitive] =      "пяти",
                    [Cases.Dative] =        "пяти",
                    [Cases.Accusative] =    "пять",
                    [Cases.Instrumental] =  "пятью",
                    [Cases.Prepositional] = "пяти"
                }
            },
            [6] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "шесть",
                    [Cases.Genitive] =      "шести",
                    [Cases.Dative] =        "шести",
                    [Cases.Accusative] =    "шесть",
                    [Cases.Instrumental] =  "шестью",
                    [Cases.Prepositional] = "шести"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "шесть",
                    [Cases.Genitive] =      "шести",
                    [Cases.Dative] =        "шести",
                    [Cases.Accusative] =    "шесть",
                    [Cases.Instrumental] =  "шестью",
                    [Cases.Prepositional] = "шести"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "шесть",
                    [Cases.Genitive] =      "шести",
                    [Cases.Dative] =        "шести",
                    [Cases.Accusative] =    "шесть",
                    [Cases.Instrumental] =  "шестью",
                    [Cases.Prepositional] = "шести"
                }
            },
            [7] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "семь",
                    [Cases.Genitive] =      "семи",
                    [Cases.Dative] =        "семи",
                    [Cases.Accusative] =    "семь",
                    [Cases.Instrumental] =  "семью",
                    [Cases.Prepositional] = "семи"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "семь",
                    [Cases.Genitive] =      "семи",
                    [Cases.Dative] =        "семи",
                    [Cases.Accusative] =    "семь",
                    [Cases.Instrumental] =  "семью",
                    [Cases.Prepositional] = "семи"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "семь",
                    [Cases.Genitive] =      "семи",
                    [Cases.Dative] =        "семи",
                    [Cases.Accusative] =    "семь",
                    [Cases.Instrumental] =  "семью",
                    [Cases.Prepositional] = "семи"
                }
            },
            [8] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "восемь",
                    [Cases.Genitive] =      "восьми",
                    [Cases.Dative] =        "восьми",
                    [Cases.Accusative] =    "восемь",
                    [Cases.Instrumental] =  "восемью",
                    [Cases.Prepositional] = "восьми"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "восемь",
                    [Cases.Genitive] =      "восьми",
                    [Cases.Dative] =        "восьми",
                    [Cases.Accusative] =    "восемь",
                    [Cases.Instrumental] =  "восемью",
                    [Cases.Prepositional] = "восьми"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "восемь",
                    [Cases.Genitive] =      "восьми",
                    [Cases.Dative] =        "восьми",
                    [Cases.Accusative] =    "восемь",
                    [Cases.Instrumental] =  "восемью",
                    [Cases.Prepositional] = "восьми"
                }
            },
            [9] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "девять",
                    [Cases.Genitive] =      "девяти",
                    [Cases.Dative] =        "девяти",
                    [Cases.Accusative] =    "девять",
                    [Cases.Instrumental] =  "девятью",
                    [Cases.Prepositional] = "девяти"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "девять",
                    [Cases.Genitive] =      "девяти",
                    [Cases.Dative] =        "девяти",
                    [Cases.Accusative] =    "девять",
                    [Cases.Instrumental] =  "девятью",
                    [Cases.Prepositional] = "девяти"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "девять",
                    [Cases.Genitive] =      "девяти",
                    [Cases.Dative] =        "девяти",
                    [Cases.Accusative] =    "девять",
                    [Cases.Instrumental] =  "девятью",
                    [Cases.Prepositional] = "девяти"
                }
            },
            [10] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "десять",
                    [Cases.Genitive] =      "десяти",
                    [Cases.Dative] =        "десяти",
                    [Cases.Accusative] =    "десять",
                    [Cases.Instrumental] =  "десятью",
                    [Cases.Prepositional] = "десяти"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "десять",
                    [Cases.Genitive] =      "десяти",
                    [Cases.Dative] =        "десяти",
                    [Cases.Accusative] =    "десять",
                    [Cases.Instrumental] =  "десятью",
                    [Cases.Prepositional] = "десяти"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "десять",
                    [Cases.Genitive] =      "десяти",
                    [Cases.Dative] =        "десяти",
                    [Cases.Accusative] =    "десять",
                    [Cases.Instrumental] =  "десятью",
                    [Cases.Prepositional] = "десяти"
                }
            },
            [11] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "одиннадцать",
                    [Cases.Genitive] =      "одиннадцати",
                    [Cases.Dative] =        "одиннадцати",
                    [Cases.Accusative] =    "одиннадцать",
                    [Cases.Instrumental] =  "одиннадцатью",
                    [Cases.Prepositional] = "одиннадцати"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "одиннадцать",
                    [Cases.Genitive] =      "одиннадцати",
                    [Cases.Dative] =        "одиннадцати",
                    [Cases.Accusative] =    "одиннадцать",
                    [Cases.Instrumental] =  "одиннадцатью",
                    [Cases.Prepositional] = "одиннадцати"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "одиннадцать",
                    [Cases.Genitive] =      "одиннадцати",
                    [Cases.Dative] =        "одиннадцати",
                    [Cases.Accusative] =    "одиннадцать",
                    [Cases.Instrumental] =  "одиннадцатью",
                    [Cases.Prepositional] = "одиннадцати"
                }
            },
            [12] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "двенадцать",
                    [Cases.Genitive] =      "двенадцати",
                    [Cases.Dative] =        "двенадцати",
                    [Cases.Accusative] =    "двенадцать",
                    [Cases.Instrumental] =  "двенадцатью",
                    [Cases.Prepositional] = "двенадцати"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "двенадцать",
                    [Cases.Genitive] =      "двенадцати",
                    [Cases.Dative] =        "двенадцати",
                    [Cases.Accusative] =    "двенадцать",
                    [Cases.Instrumental] =  "двенадцатью",
                    [Cases.Prepositional] = "двенадцати"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "двенадцать",
                    [Cases.Genitive] =      "двенадцати",
                    [Cases.Dative] =        "двенадцати",
                    [Cases.Accusative] =    "двенадцать",
                    [Cases.Instrumental] =  "двенадцатью",
                    [Cases.Prepositional] = "двенадцати"
                }
            },
            [13] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "тринадцать",
                    [Cases.Genitive] =      "тринадцати",
                    [Cases.Dative] =        "тринадцати",
                    [Cases.Accusative] =    "тринадцать",
                    [Cases.Instrumental] =  "тринадцатью",
                    [Cases.Prepositional] = "тринадцати"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "тринадцать",
                    [Cases.Genitive] =      "тринадцати",
                    [Cases.Dative] =        "тринадцати",
                    [Cases.Accusative] =    "тринадцать",
                    [Cases.Instrumental] =  "тринадцатью",
                    [Cases.Prepositional] = "тринадцати"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "тринадцать",
                    [Cases.Genitive] =      "тринадцати",
                    [Cases.Dative] =        "тринадцати",
                    [Cases.Accusative] =    "тринадцать",
                    [Cases.Instrumental] =  "тринадцатью",
                    [Cases.Prepositional] = "тринадцати"
                }
            },
            [14] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "четырнадцать",
                    [Cases.Genitive] =      "четырнадцати",
                    [Cases.Dative] =        "четырнадцати",
                    [Cases.Accusative] =    "четырнадцать",
                    [Cases.Instrumental] =  "четырнадцатью",
                    [Cases.Prepositional] = "четырнадцати"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "четырнадцать",
                    [Cases.Genitive] =      "четырнадцати",
                    [Cases.Dative] =        "четырнадцати",
                    [Cases.Accusative] =    "четырнадцать",
                    [Cases.Instrumental] =  "четырнадцатью",
                    [Cases.Prepositional] = "четырнадцати"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "четырнадцать",
                    [Cases.Genitive] =      "четырнадцати",
                    [Cases.Dative] =        "четырнадцати",
                    [Cases.Accusative] =    "четырнадцать",
                    [Cases.Instrumental] =  "четырнадцатью",
                    [Cases.Prepositional] = "четырнадцати"
                }
            },
            [15] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "пятнадцать",
                    [Cases.Genitive] =      "пятнадцати",
                    [Cases.Dative] =        "пятнадцати",
                    [Cases.Accusative] =    "пятнадцать",
                    [Cases.Instrumental] =  "пятнадцатью",
                    [Cases.Prepositional] = "пятнадцати"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "пятнадцать",
                    [Cases.Genitive] =      "пятнадцати",
                    [Cases.Dative] =        "пятнадцати",
                    [Cases.Accusative] =    "пятнадцать",
                    [Cases.Instrumental] =  "пятнадцатью",
                    [Cases.Prepositional] = "пятнадцати"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "пятнадцать",
                    [Cases.Genitive] =      "пятнадцати",
                    [Cases.Dative] =        "пятнадцати",
                    [Cases.Accusative] =    "пятнадцать",
                    [Cases.Instrumental] =  "пятнадцатью",
                    [Cases.Prepositional] = "пятнадцати"
                }
            },
            [16] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "шестнадцать",
                    [Cases.Genitive] =      "шестнадцати",
                    [Cases.Dative] =        "шестнадцати",
                    [Cases.Accusative] =    "шестнадцать",
                    [Cases.Instrumental] =  "шестнадцатью",
                    [Cases.Prepositional] = "шестнадцати"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "шестнадцать",
                    [Cases.Genitive] =      "шестнадцати",
                    [Cases.Dative] =        "шестнадцати",
                    [Cases.Accusative] =    "шестнадцать",
                    [Cases.Instrumental] =  "шестнадцатью",
                    [Cases.Prepositional] = "шестнадцати"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "шестнадцать",
                    [Cases.Genitive] =      "шестнадцати",
                    [Cases.Dative] =        "шестнадцати",
                    [Cases.Accusative] =    "шестнадцать",
                    [Cases.Instrumental] =  "шестнадцатью",
                    [Cases.Prepositional] = "шестнадцати"
                }
            },
            [17] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "семнадцать",
                    [Cases.Genitive] =      "семнадцати",
                    [Cases.Dative] =        "семнадцати",
                    [Cases.Accusative] =    "семнадцать",
                    [Cases.Instrumental] =  "семнадцатью",
                    [Cases.Prepositional] = "семнадцати"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "семнадцать",
                    [Cases.Genitive] =      "семнадцати",
                    [Cases.Dative] =        "семнадцати",
                    [Cases.Accusative] =    "семнадцать",
                    [Cases.Instrumental] =  "семнадцатью",
                    [Cases.Prepositional] = "семнадцати"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "семнадцать",
                    [Cases.Genitive] =      "семнадцати",
                    [Cases.Dative] =        "семнадцати",
                    [Cases.Accusative] =    "семнадцать",
                    [Cases.Instrumental] =  "семнадцатью",
                    [Cases.Prepositional] = "семнадцати"
                }
            },
            [18] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "восемнадцать",
                    [Cases.Genitive] =      "восемнадцати",
                    [Cases.Dative] =        "восемнадцати",
                    [Cases.Accusative] =    "восемнадцать",
                    [Cases.Instrumental] =  "восемнадцатью",
                    [Cases.Prepositional] = "восемнадцати"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "восемнадцать",
                    [Cases.Genitive] =      "восемнадцати",
                    [Cases.Dative] =        "восемнадцати",
                    [Cases.Accusative] =    "восемнадцать",
                    [Cases.Instrumental] =  "восемнадцатью",
                    [Cases.Prepositional] = "восемнадцати"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "восемнадцать",
                    [Cases.Genitive] =      "восемнадцати",
                    [Cases.Dative] =        "восемнадцати",
                    [Cases.Accusative] =    "восемнадцать",
                    [Cases.Instrumental] =  "восемнадцатью",
                    [Cases.Prepositional] = "восемнадцати"
                }
            },
            [19] = new GendersTable()
            {
                [Genders.Masculine] = new CasesTable()
                {
                    [Cases.Nominative] =    "девятнадцать",
                    [Cases.Genitive] =      "девятнадцати",
                    [Cases.Dative] =        "девятнадцати",
                    [Cases.Accusative] =    "девятнадцать",
                    [Cases.Instrumental] =  "девятнадцатью",
                    [Cases.Prepositional] = "девятнадцати"
                },
                [Genders.Feminine] = new CasesTable()
                {
                    [Cases.Nominative] =    "девятнадцать",
                    [Cases.Genitive] =      "девятнадцати",
                    [Cases.Dative] =        "девятнадцати",
                    [Cases.Accusative] =    "девятнадцать",
                    [Cases.Instrumental] =  "девятнадцатью",
                    [Cases.Prepositional] = "девятнадцати"
                },
                [Genders.Neuter] = new CasesTable()
                {
                    [Cases.Nominative] =    "девятнадцать",
                    [Cases.Genitive] =      "девятнадцати",
                    [Cases.Dative] =        "девятнадцати",
                    [Cases.Accusative] =    "девятнадцать",
                    [Cases.Instrumental] =  "девятнадцатью",
                    [Cases.Prepositional] = "девятнадцати"
                }
            }
        };
    }
}