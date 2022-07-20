using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Exercise
{
    internal class Default_Vehicle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving the generic vehicle");
        }
    }
}
