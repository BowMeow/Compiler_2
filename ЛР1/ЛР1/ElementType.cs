using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР1
{
    public enum ElementType
    { 
        ERROR=-1,
        parameter=1,
        assignmentOperator =2,
        quotes=3,
        leftBraces=4,
        rightBraces=5,
        leftParentheses=6,
        rightParentheses=7,
        colon=8,
        dot=9,
        plus=10,
        minus=11,
        delimited=12 //разделитель
    }
}
