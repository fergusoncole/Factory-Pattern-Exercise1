using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Exercise
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfTires)
        {
            switch (numberOfTires)
            {
                case 2:
                    return new Motorcycle();
                case 4:     
                    return new Car();
                case 16:
                    return new BigRig();
                default:
                    return new Default_Vehicle();
            }
               

        }

    }
}
