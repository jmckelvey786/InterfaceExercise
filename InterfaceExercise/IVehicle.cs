using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

    }
}
