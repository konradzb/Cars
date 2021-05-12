using System;

//API returns this object instead of Car itself
//It's good practise and reduces chances of the app breaking down
namespace Cars.Dtos 
{
    public record CarDto
    {
        public int Id { get; init; }
        public int ModelId { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public DateTime ProductionDate { get; set; }
        public bool IsAvailable { get; set; }
        public double PricePerDay { get; set; }

        public CarDto(int id, int modelId, int mileage, string color, DateTime productionDate, bool isAvailable, double pricePerDay)
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
