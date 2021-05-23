using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Dtos;
using Cars.Model;

namespace Cars.Repo
{
    public interface ICarDriveDao
    {
        List<CarDrive> GetAllCarDrives();
        CarDrive GetCarDriveById(int id);
    }
}
