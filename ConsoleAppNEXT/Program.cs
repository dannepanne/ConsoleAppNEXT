using System;
using System.Collections.Generic;

namespace ConsoleAppNEXT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> minList = new List<string>();

            string korv = "bratwurst";
            string bröd = "levain";
            minList.Add(bröd);
            minList.Add(korv);

            Console.WriteLine(minList.Count);
        }
    }
}
