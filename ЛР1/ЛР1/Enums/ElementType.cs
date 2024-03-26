using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР1
{
    public enum ElementType
    {
        /// <summary>
        /// Ошибка.
        /// </summary>
        ERROR = -1,

        /// <summary>
        /// Переменная.
        /// </summary>
        Parameter = 1,

        /// <summary>
        /// Оператор присваивания.
        /// </summary>
        AssignmentOperator = 2,

        /// <summary>
        /// Кавычки
        /// </summary>
        Quotes = 3,
        LeftBraces = 4,
        RightBraces = 5,
        LeftParentheses = 6,
        RightParentheses = 7,
        Colon = 8,
        Dot = 9,
        Plus = 10,
        Minus = 11,

        /// <summary>
        /// Разделитель
        /// </summary>
        Delimited = 12,

        FloatDigit = 13,
        IntDigit = 14,
        ExpDigit = 15,
    }
}
