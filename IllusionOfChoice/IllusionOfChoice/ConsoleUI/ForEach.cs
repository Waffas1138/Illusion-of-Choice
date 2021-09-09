using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class ForEach
    {
        public static void DisplayValues(List<string> input) // this for each loop is set up to display all the items in our lists when they are called or needed.
        {
            foreach (string item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
