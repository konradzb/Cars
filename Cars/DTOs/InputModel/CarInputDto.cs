using System;

namespace Cars.Dtos

{
    public class CarInputDto
    {
        public int Mileage { get; set; }
        public string Color { get; set; }
        public string Generation { get; set; }
        public DateTime ProductionDate { get; set; }
        public bool IsAvailable { get; set; }
        public int IdFuelType { get; set; }

        public CarInputDto(int mileage, string color, string generation, DateTime productionDate, bool isAvailable, int idFuelType)
        {
            Mileage = mileage;
            Color = color;
            Generation = generation;
            ProductionDate = productionDate;
            IsAvailable = isAvailable;
            IdFuelType = idFuelType;
        }
    }
}

