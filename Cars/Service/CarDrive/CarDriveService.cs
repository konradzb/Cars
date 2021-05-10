using Cars.Dtos;
using Cars.Model;
using Cars.Repo;
using Cars.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Service
{
    public class CarDriveService : ICarDriveService
    {
        private readonly ICarDriveDao carDrivesDao;
        public CarDriveService(ICarDriveDao carDrivesDao)
        {
            this.carDrivesDao = carDrivesDao;
        }
        public IEnumerable<CarDriveDto> GetAllCarDrives()
        {
            var carDrives = carDrivesDao.GetAllCarDrives().ConvertAll(carDrive => carDrive.AsDto());
            return carDrives;
        }

        public ActionResult<CarDriveDto> GetCarDriveById(int id)
        {
            var carDrive = carDrivesDao.GetCarDriveById(id);
            if(carDrive is null)
            {
                return null;
            }
            return carDrive.AsDto();
        }
    }
}
