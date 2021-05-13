using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third_lab
{
    class Truck:Transport
    {
        public Truck()
        {

        }
        public Truck(string name, string ID, float speed, int countPassengerSeats, Marks marks) : base(name, ID, speed, countPassengerSeats, marks)
        {

        }
        public override void Beep()
        {
            Console.Beep(800, 500);
        }
    }
}
