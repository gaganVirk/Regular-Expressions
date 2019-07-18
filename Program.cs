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
            /*   string theString = "We hold these truths to be self-evident, that all men are created equal, that " +
                   "they are endowed by their Creator with certain unalienable Rights, that among these are Life, " +
                   "Liberty and the pursuit of Happiness. "; */
            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine("The third character : {0}", s1[2]);
            Console.WriteLine("H appears in each string: {0}", s1.ToUpper().IndexOf('H') >= 0 ? "Yes" : "No");
            Console.WriteLine("Two strings are same: {0}", s1.CompareTo(s2) == 0 ? "Same" : "Diff");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}

