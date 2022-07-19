using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public Truck()
		{
		}

        public string BedSize { get; set; }
        public bool CanTow { get; set; }

		public string ModelName { get; set; }
		public bool CanDrive { get; set; }
		public bool HasDoors { get; set; }
		public int NumWheels { get; set; }

		public string Country { get; set; }
		public string ManufacturerName { get; set; }
	}
}

