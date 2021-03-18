using System;
namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string Alphabet = "qwertyuioplkjhgfdsazxcvbnm";
            string Output = "";
            int Length = rnd.Next(1, 4);
            for (int i = 0; i < Length; i++)
            {
                int temp = rnd.Next(0, Alphabet.Length);
                Output += Alphabet[temp];
            }
            Console.WriteLine($"Your random string is {Output}");
        }
    }
}