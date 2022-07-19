using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            // DONE - Create 2 Interfaces called IVehicle & ICompany

            // DONE - Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* DONE - Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /* DONE - Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /* DONE - Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * DONE - Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var myCar = new Car()
            {
                Country = "USA",
                ManufacturerName = "Chevy",
                ModelName = "Chevelle",
                CanDrive = true,
                HasDoors = true,
                NumWheels = 4,
                TrunkSize = "small",
                HasLowClearance = true
            };

            var myTruck = new Truck()
            {
                Country = "Japan",
                ManufacturerName = "Toyota",
                ModelName = "Tundra",
                CanDrive = true,
                HasDoors = true,
                NumWheels = 4,
                BedSize = "large",
                CanTow = true
            };

            var mySUV = new SUV()
            {
                Country = "South Korea",
                ManufacturerName = "Hyundai",
                ModelName = "SantaFe",
                CanDrive = true,
                HasDoors = true,
                NumWheels = 4,
                CargoSize = "ample",
                HasRearWipers = true
            };

            Console.WriteLine($"This {myCar.ManufacturerName} {myCar.ModelName} was made in the {myCar.Country} and comes with {myCar.NumWheels} wheels and a {myCar.TrunkSize} trunk.");
            Console.WriteLine($"Capable of driving: {myCar.CanDrive}");
            Console.WriteLine($"Comes with doors: {myCar.HasDoors}");
            Console.WriteLine($"Low clearance: {myCar.HasLowClearance}\n");

            Console.WriteLine($"This {myTruck.ManufacturerName} {myTruck.ModelName} was made in {myTruck.Country} and comes with {myTruck.NumWheels} wheels and a {myTruck.BedSize} bed.");
            Console.WriteLine($"Capable of driving: {myTruck.CanDrive}");
            Console.WriteLine($"Comes with doors: {myTruck.HasDoors}");
            Console.WriteLine($"Has towing capabilities: {myTruck.CanTow}\n");

            Console.WriteLine($"This {mySUV.ManufacturerName} {mySUV.ModelName} was made in {mySUV.Country} and comes with {mySUV.NumWheels} wheels and {mySUV.CargoSize} cargo space.");
            Console.WriteLine($"Capable of driving: {mySUV.CanDrive}");
            Console.WriteLine($"Comes with doors: {mySUV.HasDoors}");
            Console.WriteLine($"Has rear wipers: {mySUV.HasRearWipers}");
        }
    }
}
