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
            string theString = "We choose to go to the moon. We choose to go to the moon in this decade and" +
                " do the other things, not because they are easy, but because they are hard, because that" +
                " goal will serve to organize and measure the best of our energies and skills, because that " +
                "challenge is one that we are willing to accept, one we are unwilling to postpone, and" +
                " one which we intend to win, and the others, too. ";

            int counter = 0;
            while (theString.IndexOf("the ") != -1)
            {
                theString = theString.Substring(theString.IndexOf("the") + 4);
                    counter++;
            }
            Console.WriteLine("Word \"the\" occurred {0} times", counter);
        }

        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}

