using System;
namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input first number");
            ulong FirstUserAnswer, SecondUserAnswer;
            while (!ulong.TryParse(Console.ReadLine(), out FirstUserAnswer))
            {
                Console.WriteLine("Error Input");
            }
            Console.WriteLine("input second number");
            while (!ulong.TryParse(Console.ReadLine(), out SecondUserAnswer))
            {
                Console.WriteLine("Error Input");
            }
            if (FirstUserAnswer > SecondUserAnswer)
            {
                ulong temp = FirstUserAnswer;
                FirstUserAnswer = SecondUserAnswer;
                SecondUserAnswer = temp;
            }
            ulong tmp = SecondUserAnswer;
            ulong kount = 0;
            ulong number = tmp;
            while (number != 1)
            {
                tmp = number;
                while (tmp % 2 == 0)
                {
                    kount++;
                    tmp /= 2;
                }
                number--;
            }
            Console.WriteLine($"Your answer is {kount}");
        }
    }
}
