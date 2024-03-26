using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace ЛР1
{
    public class Lexemes
    {
        public List<Element> Tokenize(string input)
        {
            var elements = new List<Element>();
            int lineNumber = 1;
            int startPos = 1;

            var mathesRegex = Regex.Matches(input, CommonHelper.mainPattern);

            foreach (Match match in mathesRegex)
            {
                string value = match.Value.Trim();
                ElementType type = value.SetElementType();

                if (type == 0)
                {
                    type = value.FindElementType();
                }

                elements.Add(new Element(type, value, lineNumber, startPos));
                startPos += value.Length;
            }

            return elements;
        }
    }


}
