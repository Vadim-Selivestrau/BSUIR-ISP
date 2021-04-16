using System;
using System.Collections.Generic;
namespace third_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport car1 = new Transport("car1", "1", 50, 1);
            Transport car2 = new Transport("car2", "2", 50, 1);
            Transport car3 = new Transport("car3", "3", 50, 1);
            Garage g = new Garage();
            g.AddCar(car1);
            g.AddCar(car2);
            g.AddCar(car3);
            Console.WriteLine(g["1"].ToString());
            Console.WriteLine(g.FindTransport("2"));
        }
    }
}
