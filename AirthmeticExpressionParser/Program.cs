using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirthmeticExpressionParser
{

    class Program
    {
        static void Main(string[] args)
        {
            var tokens = new PlusMinusTokenizer().Scan("1+2+0+10-20");

            var parser = new PlusMinusParser(tokens);

            var res = parser.Parse();



        }
    }
}
