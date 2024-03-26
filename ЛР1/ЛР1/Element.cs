using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР1
{
    public class Element
    {
        public ElementType Type { get; set; }
        public string Value { get; set; }
        public int LineNumber { get; set; }
        public int StartPos { get; set; }

        public Element(ElementType type, string value, int lineNumber, int startPos)
        {
            Type = type;
            Value = value;
            LineNumber = lineNumber;
            StartPos = startPos;
        }

        public Element() { }
    }
}