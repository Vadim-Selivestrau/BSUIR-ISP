﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace ConsoleApp1
{
    class Melody
    {
        public void PlaySong(int numb)
        {
            switch (numb)
            {
                case 1:                 //jingle balls
                    Console.Beep(659, 300);
                    Console.Beep(659, 300);
                    Console.Beep(659, 300);
                    Thread.Sleep(300);
                    Console.Beep(659, 300);
                    Console.Beep(659, 300);
                    Console.Beep(659, 300);
                    Thread.Sleep(300);
                    Console.Beep(659, 300);
                    Console.Beep(783, 300);
                    Console.Beep(523, 300);
                    Console.Beep(587, 300);
                    Console.Beep(659, 300);
                    Console.Beep(261, 300);
                    Console.Beep(293, 300);
                    Console.Beep(329, 300);
                    Console.Beep(698, 300);
                    Console.Beep(698, 300);
                    Console.Beep(698, 300);
                    Thread.Sleep(300);
                    Console.Beep(698, 300);
                    Console.Beep(659, 300);
                    Console.Beep(659, 300);
                    Thread.Sleep(300);
                    Console.Beep(659, 300);
                    Console.Beep(587, 300);
                    Console.Beep(587, 300);
                    Console.Beep(659, 300);
                    Console.Beep(587, 300);
                    Thread.Sleep(300);
                    Console.Beep(783, 300);
                    Thread.Sleep(300);
                    break;
                case 2:                 //grasshoper
                    Console.Beep(440, 300);
                    Console.Beep(330, 300);
                    Console.Beep(440, 300);
                    Console.Beep(330, 300);
                    Console.Beep(440, 300);
                    Console.Beep(415, 300);
                    Console.Beep(415, 300);
                    Thread.Sleep(600);
                    Console.Beep(415, 300);
                    Console.Beep(330, 300);
                    Console.Beep(415, 300);
                    Console.Beep(330, 300);
                    Console.Beep(415, 300);
                    Console.Beep(440, 300);
                    Console.Beep(440, 300);
                    Thread.Sleep(600);
                    Console.Beep(440, 300);
                    Console.Beep(494, 300);
                    Console.Beep(494, 100);
                    Console.Beep(494, 100);
                    Console.Beep(494, 300);
                    Console.Beep(494, 300);
                    Console.Beep(523, 300);
                    Console.Beep(523, 100);
                    Console.Beep(523, 100);
                    Console.Beep(523, 300);
                    Console.Beep(523, 300);
                    Console.Beep(523, 300);
                    Console.Beep(494, 300);
                    Console.Beep(440, 300);
                    Console.Beep(415, 300);
                    Console.Beep(440, 800);
                    break;
                case 3:         //in forest born elka
                    Console.Beep(247, 500);
                    Console.Beep(417, 500);
                    Console.Beep(417, 500);
                    Console.Beep(370, 500);
                    Console.Beep(417, 500);
                    Console.Beep(329, 500);
                    Console.Beep(247, 500);
                    Console.Beep(247, 500);
                    Console.Beep(247, 500);
                    Console.Beep(417, 500);
                    Console.Beep(417, 500);
                    Console.Beep(370, 500);
                    Console.Beep(417, 500);
                    Console.Beep(497, 500);
                    Thread.Sleep(500);
                    Console.Beep(497, 500);
                    Console.Beep(277, 500);
                    Console.Beep(277, 500);
                    Console.Beep(440, 500);
                    Console.Beep(440, 500);
                    Console.Beep(417, 500);
                    Console.Beep(370, 500);
                    Console.Beep(329, 500);
                    Console.Beep(247, 500);
                    Console.Beep(417, 500);
                    Console.Beep(417, 500);
                    Console.Beep(370, 500);
                    Console.Beep(417, 500);
                    Console.Beep(329, 500);
                    break;
                case 4:                    //mission imposible
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(932, 150);
                    Thread.Sleep(150);
                    Console.Beep(1047, 150);
                    Thread.Sleep(150);
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(699, 150);
                    Thread.Sleep(150);
                    Console.Beep(740, 150);
                    Thread.Sleep(150);
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(932, 150);
                    Thread.Sleep(150);
                    Console.Beep(1047, 150);
                    Thread.Sleep(150);
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(699, 150);
                    Thread.Sleep(150);
                    Console.Beep(740, 150);
                    Thread.Sleep(150);
                    Console.Beep(932, 150);
                    Console.Beep(784, 150);
                    Console.Beep(587, 1200);
                    Thread.Sleep(75);
                    Console.Beep(932, 150);
                    Console.Beep(784, 150);
                    Console.Beep(554, 1200);
                    Thread.Sleep(75);
                    Console.Beep(932, 150);
                    Console.Beep(784, 150);
                    Console.Beep(523, 1200);
                    Thread.Sleep(150);
                    Console.Beep(466, 150);
                    Console.Beep(523, 150);
                    break;
                case 5:                     //fur elise
                    Console.Beep(659, 120);
                    Thread.Sleep(130);
                    Console.Beep(622, 120);
                    Thread.Sleep(130);
                    Console.Beep(659, 120);
                    Thread.Sleep(130);
                    Console.Beep(622, 120);
                    Thread.Sleep(130);
                    Console.Beep(659, 120);
                    Thread.Sleep(130);
                    Console.Beep(494, 120);
                    Thread.Sleep(130);
                    Console.Beep(587, 120);
                    Thread.Sleep(130);
                    Console.Beep(523, 120);
                    Thread.Sleep(130);
                    Console.Beep(440, 120);
                    Thread.Sleep(150);
                    Console.Beep(262, 120);
                    Thread.Sleep(130);
                    Console.Beep(330, 120);
                    Thread.Sleep(130);
                    Console.Beep(440, 120);
                    Thread.Sleep(130);
                    Console.Beep(494, 120);
                    Thread.Sleep(150);
                    Console.Beep(330, 120);
                    Thread.Sleep(130);
                    Console.Beep(415, 120);
                    Thread.Sleep(130);
                    Console.Beep(494, 120);
                    Thread.Sleep(130);
                    Console.Beep(523, 120);
                    Thread.Sleep(150);
                    Console.Beep(330, 120);
                    Thread.Sleep(130);
                    Console.Beep(659, 120);
                    Thread.Sleep(130);
                    Console.Beep(622, 120);
                    Thread.Sleep(130);
                    Console.Beep(659, 120);
                    Thread.Sleep(130);
                    Console.Beep(622, 120);
                    Thread.Sleep(130);
                    Console.Beep(659, 120);
                    Thread.Sleep(130);
                    Console.Beep(494, 120);
                    Thread.Sleep(130);
                    Console.Beep(587, 120);
                    Thread.Sleep(130);
                    Console.Beep(523, 120);
                    Thread.Sleep(130);
                    Console.Beep(440, 120);
                    Thread.Sleep(150);
                    Console.Beep(262, 120);
                    Thread.Sleep(130);
                    Console.Beep(330, 120);
                    Thread.Sleep(130);
                    Console.Beep(440, 120);
                    Thread.Sleep(130);
                    Console.Beep(494, 120);
                    Thread.Sleep(150);
                    Console.Beep(330, 120);
                    Thread.Sleep(130);
                    Console.Beep(523, 120);
                    Thread.Sleep(130);
                    Console.Beep(494, 120);
                    Thread.Sleep(150);
                    Console.Beep(440, 120);
                    break;
                case 6:                    //imperial marsh
                    Console.Beep(300, 500);
                    Thread.Sleep(50);
                    Console.Beep(300, 500);
                    Thread.Sleep(50);
                    Console.Beep(300, 500);
                    Thread.Sleep(50);
                    Console.Beep(250, 500);
                    Thread.Sleep(50);
                    Console.Beep(350, 250);
                    Console.Beep(300, 500);
                    Thread.Sleep(50);
                    Console.Beep(250, 500);
                    Thread.Sleep(50);
                    Console.Beep(350, 250);
                    Console.Beep(300, 500);
                    Thread.Sleep(500);
                    break;
                case 7:                     //mario them
                    Console.Beep(659, 125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(523, 125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(784, 125);
                    Thread.Sleep(375);
                    Console.Beep(392, 125);
                    Thread.Sleep(375);
                    Console.Beep(523, 125);
                    Thread.Sleep(250);
                    Console.Beep(392, 125);
                    Thread.Sleep(250);
                    Console.Beep(330, 125);
                    Thread.Sleep(250);
                    Console.Beep(440, 125);
                    Thread.Sleep(125);
                    Console.Beep(494, 125);
                    Thread.Sleep(125);
                    Console.Beep(466, 125);
                    Thread.Sleep(42);
                    Console.Beep(440, 125);
                    Thread.Sleep(125);
                    Console.Beep(392, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(784, 125);
                    Thread.Sleep(125);
                    Console.Beep(880, 125);
                    Thread.Sleep(125);
                    Console.Beep(698, 125);
                    Console.Beep(784, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(523, 125);
                    Thread.Sleep(125);
                    Console.Beep(587, 125);
                    Console.Beep(494, 125);
                    Thread.Sleep(125);
                    Console.Beep(523, 125);
                    Thread.Sleep(250);
                    Console.Beep(392, 125);
                    Thread.Sleep(250);
                    Console.Beep(330, 125);
                    Thread.Sleep(250);
                    Console.Beep(440, 125);
                    Thread.Sleep(125);
                    Console.Beep(494, 125);
                    Thread.Sleep(125);
                    Console.Beep(466, 125);
                    Thread.Sleep(42);
                    Console.Beep(440, 125);
                    Thread.Sleep(125);
                    Console.Beep(392, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(784, 125);
                    Thread.Sleep(125);
                    Console.Beep(880, 125);
                    Thread.Sleep(125);
                    Console.Beep(698, 125);
                    Console.Beep(784, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(523, 125);
                    Thread.Sleep(125);
                    break;
            }
        }
    }
}