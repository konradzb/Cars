using System;
using System.Collections.Generic;

namespace Cars.Model
{
    public record Model
    {
        public int Id { get; init; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }

        public int FuelTypeId { get; set; }  // 1-petrol, 2-diesel, 3-gas, 4-electric
        public FuelType FuelType { get; set; }
        public int CarDriveId { get; set; }  // 1-FWD, 2-RWD, 3-AWD
        public CarDrive CarDrive { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public List<Car> Cars { get; set; }

        public Model(int id, int brandId, string type, string name, int power, int fuelTypeId, int carDriveId)
        {
            Id = id;
            BrandId = brandId;
            Type = type; 
            Name = name;
            Power = power;
            this.CarDriveId = carDriveId;
            this.FuelTypeId = fuelTypeId;
        }
    }
}
