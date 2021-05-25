using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third_lab
{
    class Truck:Transport, ICar
    {
        public void FaraOn()
        {
            if (Fara == false)
            {
                Console.WriteLine("Fara Track is on");
                Fara = true;
            }
            else
            {
                Console.WriteLine("Fara Track uzhe on");
            }
            
        }
        public void FaraOff()
        {
            if (Fara == true)
            {
                Console.WriteLine("Fara Track is off");
                Fara = false;
            }
            else
            {
                Console.WriteLine("Fara Track uzhe off");
            }
        }
        public Truck()
        {

        }
        public Truck(string name, string ID, float speed, int countPassengerSeats, bool Fara, Marks marks) : base(name, ID, speed, countPassengerSeats, Fara, marks)
        {

        }
        public override void Beep()
        {
            Console.Beep(800, 500);
        }
    }
}
