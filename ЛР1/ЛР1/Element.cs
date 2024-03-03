using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР1
{
    public class Element
    {
        public int Type { get; }
        public string Value { get; }
        public int LineNumber { get; }
        public int StartPos { get; }

        public Element(int type, string value, int lineNumber, int startPos)
        {
            Type = type;
            Value = value;
            LineNumber = lineNumber;
            StartPos = startPos;
        }
    }
}