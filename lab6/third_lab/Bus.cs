using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third_lab
{
    class Bus : Transport, ICar
    {
        public void FaraOn()
        {
            if (Fara == false)
            {
                Console.WriteLine("Fara Bus is on");
                Fara = true;
            }
            else
            {
                Console.WriteLine("Fara Bus uzhe on");
            }

        }
        public void FaraOff()
        {
            if (Fara == true)
            {
                Console.WriteLine("Fara Bus is off");
                Fara = false;
            }
            else
            {
                Console.WriteLine("Fara Bus uzhe off");
            }
        }
        public Bus()
        { 
        
        }
        public Bus(string name, string ID, float speed, int countPassengerSeats, bool Fara, Marks marks) : base(name, ID, speed, countPassengerSeats, Fara, marks)
        {

        }
        public override void Beep()
        {
            Console.Beep(200, 500);
        }
    }
}
