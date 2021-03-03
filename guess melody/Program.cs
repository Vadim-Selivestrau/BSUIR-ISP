using System;
using System.Threading; //Для создания пауз в мелодии
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Round round = new Round();
            Console.WriteLine("Welcome!");
            Thread.Sleep(1300);
            Console.Clear();
            TP:
            Console.WriteLine("1.Start Game\n2.Exit");
            int Count = 0;
            ConsoleKey Choice = Console.ReadKey().Key;
            switch(Choice)
            { 
                case ConsoleKey.D1:
                    while (Count != 7) {
                        Console.Clear();
                        Console.WriteLine($"Song number {++Count}");
                        round.NewRound(Count);
                        Console.Clear();
                        round.Answer(Count-1);
                    }
                    Console.Clear();
                    Console.WriteLine($"Your Score {round.GetScore()}");
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Good bye!\nDo widzenia!\nAre Vua!");
                    Thread.Sleep(1300);
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("ERROR!Invalid input!\nPleas retry input");
                    Thread.Sleep(1300);
                    Console.Clear();
                    goto TP;
            }
        }
    }
}