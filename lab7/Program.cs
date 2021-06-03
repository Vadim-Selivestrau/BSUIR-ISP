using System;
using System.Collections.Generic;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Number> fractions = new List<Number>()
            {
                Number.GetFraction("3/8"),
                Number.GetFraction("6/16"),
                Number.GetFraction("13,44"),
                Number.GetFraction("42"),
                Number.GetFraction("3/8"),
                Number.GetFraction("6/16"),
                Number.GetFraction("13,44"),
                Number.GetFraction("42"),
                Number.GetFraction("3/8"),
                Number.GetFraction("6/16"),
                Number.GetFraction("13,44"),
                Number.GetFraction("42")
            };


            fractions.Add(fractions[0] + fractions[2]);
            fractions.Add(fractions[3] - fractions[1]);
            fractions.Add(fractions[6] * fractions[4]);
            fractions.Add(fractions[5] / fractions[7]);
            fractions.Add(fractions[3].Clone() as Number);

            Console.WriteLine("List of all fractions:");
            fractions.ForEach(i => Console.WriteLine("{0:S}", i));

            Console.WriteLine("\noutput fraction in different formats:");
            Number testFraction = new Number(-42, 13);
            Console.WriteLine("{0:S}", testFraction);
            Console.WriteLine("{0:M}", testFraction);
            Console.WriteLine("{0:D}", testFraction);
            Console.WriteLine("{0:I}", testFraction);


            Console.WriteLine("\nCoversion:");
            Console.WriteLine((short)testFraction);
            Console.WriteLine((int)testFraction);
            Console.WriteLine((long)testFraction);
            Console.WriteLine((float)testFraction);
            Console.WriteLine((double)testFraction);
            Console.WriteLine(Convert.ToBoolean(testFraction));
            Console.WriteLine(Convert.ToString(testFraction));

            Console.WriteLine("\nComparison:");
            Console.WriteLine(fractions[0] == fractions[1]);
            Console.WriteLine(fractions[3] != fractions[5]);
            Console.WriteLine(fractions[6] < fractions[8]);
            Console.WriteLine(fractions[1] >= fractions[7]);
        }
    }
}