 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public class Tester
    {
        public void Run()
        {
              string theString = "We hold these truths to be self-evident, that all men are created equal, that " +
                   "they are endowed by their Creator with certain unalienable Rights, that among these are Life, " +
                   "Liberty and the pursuit of Happiness. ";

            int id = 1;
            Regex theRegex = new Regex(" |, |,");
            foreach (string myString in theRegex.Split(theString))
            {
                Console.WriteLine("{0}: {1}\n", id, myString);
            }


            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}

