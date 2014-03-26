using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourOfCode
{
    class FontChange
    {
        public static void redText(String input)
        {
            //Example how to change console text color programmatically
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(input);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
