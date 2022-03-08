using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest3
{
    internal class Car
    {
        public int vin;
        public string colour;
        public int odo;
        public Car(int _vin, string _colour, int _odo)
        {
            this.vin = _vin;
            colour = _colour;
            odo = _odo;
        }
        public void sayHello()
        {
            Console.WriteLine("May vin is " + vin);
        }
    }

}
