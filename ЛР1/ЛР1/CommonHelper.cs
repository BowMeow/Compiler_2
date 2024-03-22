using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР1
{
    public static class CommonHelper
    {
        public static readonly Dictionary<ElementType, string> elementTitles = new Dictionary<ElementType, string>()
        {
            {ElementType.ERROR, "Ошибка" },
            {ElementType.parameter, "Имя переменной" },
            {ElementType.assignmentOperator, "Оператор присваивания" },
            {ElementType.quotes, "Кавычки" },
            {ElementType.leftBraces, "Левая фигурная скобка" },
            {ElementType.rightBraces, "Правая фигурная скобка" },
            {ElementType.leftParentheses, "Левая круглая скобка" },
            {ElementType.rightParentheses, "Правая круглая скобка" },
            {ElementType.colon, "Двоеточие" },
            {ElementType.dot, "Точка" },
            {ElementType.plus, "Плюс" },
            {ElementType.minus, "Минус" },
            {ElementType.delimited, "Разделитель" }
        };
        public static readonly Dictionary<int, string> applySymbols = new Dictionary<int, string>()
        {
            {2, "="},
            {3, "\""},
            {4, "{"},
            {5, "}"},
            {6, "("},
            {7, ")"},
            {8, ":"},
            {9, "."},
            {10, "+"},
            {11, "-"},
            {12, " "},
        };

    }
}
