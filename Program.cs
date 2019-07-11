﻿ using System;
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
            string s1 = "One,Two,Three Liberty Associates, Inc.";
            Regex theRegex = new Regex(" |, |,");
            StringBuilder sBuilder = new StringBuilder();
            int id = 1;

            foreach(string subString in theRegex.Split(s1))
            {
                sBuilder.AppendFormat("{0}: {1}\n", id++, subString);
            }
            Console.WriteLine("{0}", sBuilder);
        }
    
    static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}

