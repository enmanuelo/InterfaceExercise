using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
		public Car()
		{
		}

        public string TrunkSize { get; set; }
        public bool HasLowClearance { get; set; }

		public string ModelName { get; set; }
		public bool CanDrive { get; set; }
		public bool HasDoors { get; set; }
		public int NumWheels { get; set; }

		public string Country { get; set; }
		public string ManufacturerName { get; set; }
	}
}

