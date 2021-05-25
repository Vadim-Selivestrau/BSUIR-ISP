using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third_lab
{
    
    public enum Marks
    {
        Chevrolett = 1,
        Skoda,
        Volksvagen,
        LadaSedan,
        BMW
    }
    public class Transport
    {
        /*public void FaraOn()
        {
            Console.WriteLine("Fara is on");
        }
        public void FaraOff()
        {
            Console.WriteLine("Fara is off");
        }*/
        protected bool Fara = false;
        float speed;
        int countPassengerSeats;
        public String ID;
        Marks marks;
        String Name { get; set; }
        public Transport(string name, string ID, float speed, int countPassengerSeats, bool Fara, Marks marks)
        {
            this.marks = marks;
            Name = name;
            this.ID = ID;
            this.speed = speed;
            this.Fara = Fara;
            this.countPassengerSeats = countPassengerSeats;
        }
        public Transport()
        {
            speed = 666;
            countPassengerSeats = 2;
            ID = "test";
        }
        public virtual void Beep()
        {
            Console.Beep(600, 500);
        }
        float Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Wrong input");
                }
                else
                {
                    speed = value;
                }
            }
        }
        int CountPassengerSeats
        {
            get { return countPassengerSeats; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Wrong input");
                }
                else
                {
                    countPassengerSeats = value;
                }
            }
        }
        public override string ToString()
        {
            string ans;
            ans = "Name: " + Name + " ID: " + ID + " Speed: " + speed.ToString();
            return ans;
        }
        ~Transport()
        {
        }
    }
}
