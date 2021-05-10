using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Model;

namespace Cars.Repo
{
    public class FakeCarDriveDao : ICarDriveDao
    {
        private List<CarDrive> carDrives = new();
        public FakeCarDriveDao()
        {
            carDrives.Add(new CarDrive(1, "FWD"));
            carDrives.Add(new CarDrive(2, "RWD"));
            carDrives.Add(new CarDrive(3, "AWD"));
        }
        public List<CarDrive> GetAllCarDrives()
        {
            return carDrives;
        }

        public CarDrive GetCarDriveById(int id)
        {
            return carDrives.Find(carDrive => carDrive.Id == id);
        }
    }
}
