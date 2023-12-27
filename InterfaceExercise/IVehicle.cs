using System;
namespace InterfaceExercise
{
	public interface IVehicle : ICompany
	{
        public string Make { get; set; }
        public int Milage { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

    }


  

    //In your IVehicle:

    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: public int NumberOfWheels { get; set; }
     */
}

