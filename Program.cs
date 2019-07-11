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
            string s = "Hello";
            string s1 = "World";
            string s2 = "World";

            Console.WriteLine("s: {0} [{1}]", s, s.Length);
            Console.WriteLine("s: {0} [{1}]", s, s[2]);
            Console.WriteLine("s: {0} [{1}]", s, s.ToUpper().IndexOf('H') >= 0 ? "True" : "False");
            Console.WriteLine("s1 == s2 : {0}", String.Compare(s1,s2) == 0 ? "Same" : "Different");
            Console.WriteLine("Copy of s3: {0}", String.Compare(s1,s2,true) == 0 ? "Same" : "Different");
        }

        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}

