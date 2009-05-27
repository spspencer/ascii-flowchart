using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowchartToASCII
{
    public class StringToCharArray
    {
        public static void StringToChArray()
        {
            string s = "Test String";

            for (int index = 0; index < s.Length; index++)
                Console.WriteLine("Char: {0}", s[index]);
        }
    }
}
