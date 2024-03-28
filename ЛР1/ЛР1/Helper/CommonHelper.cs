using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ЛР1
{
    public static class CommonHelper
    {
        private static readonly string _mainPattern = @"[A-Za-z_]+\s*|[-+]?[0-9]*\.?[0-9]+|(\.\d+e|\.\d*e|\.\de)|\S";
        private static List<Element> _elementList { get; set; } = new List<Element>();

        public static readonly Dictionary<ElementType, string> elementTitles = new Dictionary<ElementType, string>()
        {
            {ElementType.ERROR, "Ошибка" },
            {ElementType.Parameter, "Имя переменной" },
            {ElementType.AssignmentOperator, "Оператор присваивания" },
            {ElementType.Quotes, "Кавычки" },
            {ElementType.LeftBraces, "Левая фигурная скобка" },
            {ElementType.RightBraces, "Правая фигурная скобка" },
            {ElementType.LeftParentheses, "Левая круглая скобка" },
            {ElementType.RightParentheses, "Правая круглая скобка" },
            {ElementType.Colon, "Двоеточие" },
            {ElementType.Dot, "Точка" },
            {ElementType.Plus, "Плюс" },
            {ElementType.Minus, "Минус" },
            {ElementType.Delimited, "Разделитель"},
            {ElementType.FloatDigit, "Число с плавающей точкой"},
            {ElementType.IntDigit, "Целое число"},
            {ElementType.ExpDigit, "Экспоненциальная запись"},
            //{ElementType.String, "Строка"},
            {ElementType.Method, "Метод"}
        };
        public static readonly Dictionary<ElementType, string> applySymbols = new Dictionary<ElementType, string>()
        {
            {ElementType.AssignmentOperator, "="},
            {ElementType.Quotes, "\""},
            {ElementType.LeftBraces, "{"},
            {ElementType.RightBraces, "}"},
            {ElementType.LeftParentheses, "("},
            {ElementType.RightParentheses, ")"},
            {ElementType.Colon, ":"},
            {ElementType.Dot, "."},
            {ElementType.Plus, "+"},
            {ElementType.Minus, "-"},
            {ElementType.Delimited, " "},
        };


        private static readonly Dictionary<ElementType, string> digitPatterns = new Dictionary<ElementType, string>()
        {
            { ElementType.ExpDigit, @"(\.\d+e|\.\d*e|\.\de)" },
            { ElementType.IntDigit, @"^\d+$"  },
            { ElementType.FloatDigit, @"^-?\d+\.?\d+?$"}
        };

        private static readonly Dictionary<ElementType, string> stringPatterns = new Dictionary<ElementType, string>()
        {
            { ElementType.Method, @"[A-Za-z_]+\s*" }
            //{ ElementType.String, @"[A-Za-z_]+\s*" }
        };

        public static List<Element> Tokenize(this string input)
        {
            int lineNumber = 1;
            int startPos = 1;
            short positionInList = 0;

            var mathesRegex = Regex.Matches(input, _mainPattern);

            foreach (Match match in mathesRegex)
            {
                string value = match.Value.Trim();

                //Определяем одиночные символы
                ElementType type = value.SetElementType();

                if (type == 0)
                {
                    type = value.FindElementType(digitPatterns);
                }

                if (type == ElementType.ERROR)
                {
                    type = value.FindElementType(stringPatterns);
                }

                _elementList.Add(new Element(type, value, lineNumber, startPos));
                startPos += value.Length;

                //Определяем имена переменных
                if (positionInList != 0 && _elementList[positionInList].Type == ElementType.AssignmentOperator)
                {
                    _elementList[positionInList - 1].Type = ElementType.Parameter;
                }

                positionInList++;
            }

            //_elementList.SetStringElementType();

            return _elementList;
        }

        private static ElementType SetElementType(this string value) => applySymbols.FirstOrDefault(x => x.Value == value).Key;

        private static ElementType FindElementType(this string value, Dictionary<ElementType, string> patterns)
        {
            foreach (var pattern in patterns)
            {
                var math = Regex.Matches(value, pattern.Value);
                if (math.Count != 0) return pattern.Key;
            }

            return ElementType.ERROR;
        }

    }
}
