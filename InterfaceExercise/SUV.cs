using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public SUV()
		{
		}

        public string CargoSize { get; set; }
        public bool HasRearWipers { get; set; }

		public string ModelName { get; set; }
		public bool CanDrive { get; set; }
		public bool HasDoors { get; set; }
		public int NumWheels { get; set; }

		public string Country { get; set; }
		public string ManufacturerName { get; set; }
	}
}

