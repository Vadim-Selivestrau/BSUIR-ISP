using System;
namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input first number");
            int FirstUserAnswer, SecondUserAnswer;
            while (!int.TryParse(Console.ReadLine(), out FirstUserAnswer))
            {
                Console.WriteLine("Error Input");
            }
            Console.WriteLine("input second number");
            while (!int.TryParse(Console.ReadLine(), out SecondUserAnswer))
            {
                Console.WriteLine("Error Input");
            }
            if (FirstUserAnswer > SecondUserAnswer)
            {
                int temp = FirstUserAnswer;
                FirstUserAnswer = SecondUserAnswer;
                SecondUserAnswer = temp;
            }
            int tmp = SecondUserAnswer;
            int kount = 0;
            int number = tmp;
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