using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : ICompany, IVehicle
    {
        public bool IsCoupe { get; set; }
        public int TrunkSize { get; set; }
        public string CompanyName { get; set; }
        public bool MadeInMerica { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
