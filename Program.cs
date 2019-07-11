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
            string statement = "To be, or not to be: That is the question: Whether ’tis nobler in the mind to suffer the slings and " +
                "arrows of outrageous fortune, or to take arms against a sea of troubles, and by opposing end them? ";

            char[] delimiters = { ',', ':', ' ' };

            string[] stringArray = statement.Split(delimiters);
            Array.Reverse(stringArray);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (string reverse in stringArray)
            {
                stringBuilder.AppendFormat("{0} ", reverse);
            }
            Console.WriteLine(stringBuilder);
        }
    
    static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}

