using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck: ICompany, IVehicle
    {
        public bool ExtendedCab { get; set; }
        public bool FourByFour { get; set; }
        public int NumberOfDoors { get; set ; }
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string CompanyName { get; set; }
        public bool MadeInMerica { get; set; }
    }
}
