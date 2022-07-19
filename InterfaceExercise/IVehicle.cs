using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
        public string ModelName { get; set; }
        public bool CanDrive { get; set; }
        public bool HasDoors { get; set; }
        public int NumWheels { get; set; }
    }
}

