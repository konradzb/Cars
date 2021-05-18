using System;

//Car model
namespace Cars.Model
{
	public record Car
	{
        public int Id { get; init; }
        public int ModelId { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public DateTime ProductionDate { get; set; }
        public bool IsAvailable { get; set; }
        public double PricePerDay { get; set; }

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
