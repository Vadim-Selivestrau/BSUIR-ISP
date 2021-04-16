using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third_lab
{
    public class Garage : Transport
    {
        int countOfTransport = 0;
        private Dictionary<string, Transport> garage;
        public Garage()
        {
            garage = new Dictionary<string, Transport>();
        }
        public Transport FindTransport(string identifier)
        {
            return garage[identifier];
        }

        public Transport this[string index]
        {
            get
            {
                if (FindTransport(index) == null)
                {
                    throw new Exception("There is no Transport with such ID\n");
                }
                return garage[index];
            }
            set
            {
                if (FindTransport(index) == null)
                {
                    throw new Exception("There is no Transport with such ID\n");
                }
                garage[index] = value;
                countOfTransport++;
            }
        }
        public void AddCar(Transport car)
        {
            garage.Add(car.ID, car);
        }
    }
}