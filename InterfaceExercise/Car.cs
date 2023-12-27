using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
        public int NumberOfDoors { get; set; }
        public string ColorofCar { get; set; }
        public bool HasLogo { get ; set ; }
        public string LogoColor { get ; set ; }
        public string Make { get ; set ; }
        public int Milage { get ; set ; }
        public string Model { get ; set ; }
        public int Year { get ; set ; }


       


        //In each of your Car, Truck, and SUV classes

        /* Create 2 members that are specific to each class
         * Example for Car: public bool HasTrunk { get; set; }
         * Example for SUV: public int NumberOfSeats { get; set; }
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         */
    }
}

