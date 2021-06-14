using System;
using System.Collections.Generic;

//Car model
namespace Cars.Model
{
	public record Car
	{
        public int Id { get; init; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public DateTime ProductionDate { get; set; }
        public bool IsAvailable { get; set; }
        public double PricePerDay { get; set; }

        public int ModelId { get; set; }
        public Model Model { get; set; }

        public List<CarRental> CarRentals { get; set; }

        public Car(int id, int modelId, int mileage, string color, DateTime productionDate, bool isAvailable, double pricePerDay)
        {
            Id = id;
            ModelId = modelId;
            Mileage = mileage;
            Color = color;
            ProductionDate = productionDate;
            IsAvailable = isAvailable;
            PricePerDay = pricePerDay;
        }
    }
}
