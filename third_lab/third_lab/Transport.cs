using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third_lab
{
    public class Transport
    {
        float speed;
        int countPassengerSeats;
        public String ID;
        String Name { get; set; }
        public Transport(string name, string ID, float speed, int countPassengerSeats)
        {
            Name = name;
            this.ID = ID;
            this.speed = speed;
            this.countPassengerSeats = countPassengerSeats;
        }
        public Transport()
        {
            speed = 666;
            countPassengerSeats = 2;
            ID = "test";
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
