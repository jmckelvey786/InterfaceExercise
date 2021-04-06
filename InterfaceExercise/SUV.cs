using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : ICompany, IVehicle
    {
        public int CargoHoldSize { get; set; }
        public int NumberOPassengers { get; set; }
        public string CompanyName { get ; set; }
        public bool MadeInMerica { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
