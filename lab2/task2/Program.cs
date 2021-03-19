using System;
namespace ConsoleApp1
{
    class Program
    {
        public static void revers(String str)
        {
            string[] Word = str.Split(' ');
            for (int i = Word.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", Word[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string");
            string input = Console.ReadLine();
            revers(input);
        }
    }
}