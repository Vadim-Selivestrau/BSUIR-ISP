using System;
using System.Collections.Generic;
namespace third_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport car1 = new Transport("car1", "1", 50, 1,false, Marks.BMW);
            Bus car2 = new Bus("car2", "2", 50, 1,true, Marks.Chevrolett);
            Truck car3 = new Truck("car3", "3", 50, 1,false, Marks.Skoda);
            Garage g = new Garage();
            g.AddCar(car1);
            g.AddCar(car2);
            g.AddCar(car3);
            Console.WriteLine(g["1"].ToString());
            Console.WriteLine(g.FindTransport("2"));
            car1.Beep();
            car2.Beep();
            car3.Beep();
            car2.FaraOn();
            car3.FaraOn();
        }
    }
}
