using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ЛР1
{
    
    public class Lexemes
    {
        private readonly Dictionary<string, int> symbols = new Dictionary<string, int>()
    {
        {"=", 2},
        {"\"", 3},
        {"{",  4},
        {"}", 4},
        {"(", 4},
        {")", 4},
        {" ", 6 },
        {".", 7},
    };

        private readonly Dictionary<string, int> exp_notation = new Dictionary<string, int>()
    {
        { @":.\d+e", 5 }, // Добавляем правило для "экспоненциальной записи"
    };

        public List<Element> Tokenize(string input)
        {
            var elements = new List<Element>();
            int lineNumber = 1;
            int startPos = 1;

            foreach (Match match in Regex.Matches(input, @"[A-Za-z_]+\s*|[-+]?[0-9]*\.?[0-9]+(?:[eE][-+]?[0-9]+)?|:.\d+e|\S"))
            {
                string value = match.Value.Trim();
                int type;

                if (exp_notation.ContainsKey(value))
                {
                    type = exp_notation[value];
                }
                else if (IsNumber(value))
                {
                    type = 8; // Число
                }
                else if (symbols.ContainsKey(value))
                {
                    type = symbols[value];
                }
                else if (IsIdentifier(value))
                {
                    type = 1; // Идентификатор
                }
                else
                {
                    type = -1; // Недопустимый символ
                }

                elements.Add(new Element(type, value, lineNumber, startPos));
                startPos += value.Length;
            }

            return elements;
        }

        private bool IsIdentifier(string value)
        {
            // Реализация проверки на идентификатор
            return !string.IsNullOrWhiteSpace(value) && char.IsLetter(value[0]);
        }

        private bool IsNumber(string value)
        {
            if (Regex.IsMatch(value, @"^[-+]?\d*\.?\d+(?:[eE][-+]?\d+)?$"))
            {
                return true;
            }

            return false;
        }
    }


}
