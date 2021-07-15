using System;
using System.Collections.Generic;

//Car model
namespace Cars.Model
{
    public record ComplexCar
    {
        public int Id { get; set; }
        public string ModelType { get; set; }
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public DateTime ProductionDate { get; set; }
        public bool IsAvailable { get; set; }
        public double PricePerDay { get; set; }
        public string FuelType { get; set; }
        public string CarDrive { get; set; }
        public int Power { get; set; }

        public ComplexCar(int id, string modelType, string modelName, string brand, int mileage, string color, DateTime productionDate, bool isAvailable, double pricePerDay, string fuelType, string carDrive, int power)
        {
            Id = id;
            ModelType = modelType;
            ModelName = modelName;
            Brand = brand;
            Mileage = mileage;
            Color = color;
            ProductionDate = productionDate;
            IsAvailable = isAvailable;
            PricePerDay = pricePerDay;
            FuelType = fuelType;
            CarDrive = carDrive;
            Power = power;
        }
    }
}
