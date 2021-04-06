using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck1 = new Truck();
            truck1.ExtendedCab = true;
            truck1.FourByFour = false;
            truck1.MadeInMerica = false;
            truck1.Make = "Toyota";
            truck1.Model = "Tundra";

            Car Car1 = new Car();
            Car1.IsCoupe = true;
            Car1.CompanyName = "Honda";

            SUV SUV1 = new SUV();
            SUV1.NumberOfDoors = 4;
            SUV1.NumberOfWheels = 3;

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
