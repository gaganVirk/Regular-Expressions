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

            string s = "To be, or not to be: That is the question: Whether 'tis nobler in the mind to suffer the" +
                 "slings and arrows of outrageous fortune, or to take arms against a sear of troubles, and " +
                 "by opposing them end them?";

            char[] delimiters = { ',', ':', ' ' };
            string[] rev = s.Split(delimiters);
            Array.Reverse(rev);
            foreach(string c in rev)
            {
                Console.Write("{0} ",c);
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

