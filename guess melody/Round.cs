using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace ConsoleApp1
{
    class Round
    {
        string[] SongNames = new string[] { "Jingl Bells","Grasshoper",
                                            "In forest born wood","Mission Impossible", "Fur Elise",
                                            "Imperial Marsh", "Mario Theme", "GodFather", "Tetris Theme",
                                            "Pirates of the caribian","Smells like teen spirit",
                                            "Show must go on","Numb","Highwei to hell", "Let It Be",
                                            "Yesterday","Radioactive", "Message man", "Where is my mind",
                                            "Back in black", "Take me to church","I hate everythink"};
        public int[] SongNamesBool = new int[22];
        public void NullBool()
        {
            for (int i = 0; i< 22; i++)
            {
                SongNamesBool[i] = 0;
            }
        }
        Melody Song = new Melody();
        
        int Score=0;
        public void NewRound(int number)
        {
            Song.PlaySong(number);
        }
        public void Answer(int number)
        {
            NullBool();
            Random rnd = new Random();
            int CorrectAnswer = rnd.Next(1, 4);
            SongNamesBool[number] = 1;
            int temp;
            if (CorrectAnswer == 1) 
            {
                Console.WriteLine($"1.{SongNames[number]}");
                while (true)
                {
                    temp = rnd.Next(0, 21);
                    if (SongNamesBool[temp] == 1)
                    {
                        continue;
                    }
                    Console.WriteLine($"2.{SongNames[temp]}");
                    SongNamesBool[temp] = 1;
                    break;
                }
                while (true)
                {
                    temp = rnd.Next(0, 21);
                    if (SongNamesBool[temp] == 1)
                    {
                        continue;
                    }
                    Console.WriteLine($"3.{SongNames[temp]}");
                    SongNamesBool[temp] = 1;
                    break;
                }
                while (true)
                {
                    temp = rnd.Next(0, 21);
                    if (SongNamesBool[temp] == 1)
                    {
                        continue;
                    }
                    Console.WriteLine($"4.{SongNames[temp]}");
                    SongNamesBool[temp] = 1;
                    break;
                }
            }
            else if (CorrectAnswer == 2) 
            {
                while (true)
                {
                    temp = rnd.Next(0, 21);
                    if (SongNamesBool[temp] == 1)
                    {
                        continue;
                    }
                    Console.WriteLine($"1.{SongNames[temp]}");
                    SongNamesBool[temp] = 1;
                    break;
                }
                Console.WriteLine($"2.{SongNames[number]}");
                while (true)
                {
                    temp = rnd.Next(0, 21);
                    if (SongNamesBool[temp] == 1)
                    {
                        continue;
                    }
                    Console.WriteLine($"3.{SongNames[temp]}");
                    SongNamesBool[temp] = 1;
                    break;
                }
                while (true)
                {
                    temp = rnd.Next(0, 21);
                    if (SongNamesBool[temp] == 1)
                    {
                        continue;
                    }
                    Console.WriteLine($"4.{SongNames[temp]}");
                    SongNamesBool[temp] = 1;
                    break;
                }
            }
            else if (CorrectAnswer == 3)
            {
                while (true)
                {
                    temp = rnd.Next(0, 21);
                    if (SongNamesBool[temp] == 1)
                    {
                        continue;
                    }
                    Console.WriteLine($"1.{SongNames[temp]}");
                    SongNamesBool[temp] = 1;
                    break;
                }
                while (true)
                {
                    temp = rnd.Next(0, 21);
                    if (SongNamesBool[temp] == 1)
                    {
                        continue;
                    }
                    Console.WriteLine($"2.{SongNames[temp]}");
                    SongNamesBool[temp] = 1;
                    break;
                }
                Console.WriteLine($"3.{SongNames[number]}");
                while (true)
                {
                    temp = rnd.Next(0, 21);
                    if (SongNamesBool[temp] == 1)
                    {
                        continue;
                    }
                    Console.WriteLine($"4.{SongNames[temp]}");
                    SongNamesBool[temp] = 1;
                    break;
                }
            }
            else
            {
                while (true)
                {
                    temp = rnd.Next(0, 21);
                    if (SongNamesBool[temp] == 1)
                    {
                        continue;
                    }
                    Console.WriteLine($"1.{SongNames[temp]}");
                    SongNamesBool[temp] = 1;
                    break;
                }
                while (true)
                {
                    temp = rnd.Next(0, 21);
                    if (SongNamesBool[temp] == 1)
                    {
                        continue;
                    }
                    Console.WriteLine($"2.{SongNames[temp]}");
                    SongNamesBool[temp] = 1;
                    break;
                }
                while (true)
                {
                    temp = rnd.Next(0, 21);
                    if (SongNamesBool[temp] == 1)
                    {
                        continue;
                    }
                    Console.WriteLine($"3.{SongNames[temp]}");
                    SongNamesBool[temp] = 1;
                    break;
                }
                Console.WriteLine($"4.{SongNames[number]}");
            }
            NullBool();
            int UserAnswer = int.Parse(Console.ReadLine());
            if (UserAnswer == CorrectAnswer)
            {
                Console.WriteLine("That is correct");
                ++Score;
            }
            else
            {
                Console.WriteLine("Sorry, that's incorrect");
            }
            Thread.Sleep(1300);
        }
        public int GetScore()
        {
            return Score;
        }
    }
}