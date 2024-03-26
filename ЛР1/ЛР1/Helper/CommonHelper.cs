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
        public static readonly string mainPattern = @"[A-Za-z_]+\s*|[-+]?[0-9]*\.?[0-9]+(?:[eE][-+]?[0-9]+)?|:.\d+e|\S";

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
            {ElementType.ExpDigit, "Экспоненциальная запись"}
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

        public static readonly Dictionary<ElementType, string> digitPatterns = new Dictionary<ElementType, string>()
        {
            { ElementType.FloatDigit, @"^-?\d+\.?\d+?$"},
            { ElementType.IntDigit, @"^[-+]?\d*\.?\d+(?:[eE][-+]?\d+)?$" },
            { ElementType.ExpDigit, @".\d+e" }
        };

        public static ElementType SetElementType(this string value) => applySymbols.FirstOrDefault(x => x.Value == value).Key;

        public static ElementType FindElementType(this string value)
        {
            foreach (var pattern in digitPatterns)
            {
                var math = Regex.Matches(value, pattern.Value);
                if (math.Count != 0) return pattern.Key;
            }

            return ElementType.ERROR;
        }


    }
}
