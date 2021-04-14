using System;

//API returns this object instead of Car itself
//It's good practise and reduces chances of the app breaking down
namespace Cars.Dtos 
{
    public record CarDto
    {
        public int Id { get; init; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public string Generation { get; set; }
        public DateTime ProductionDate { get; set; }
        public bool IsAvailable { get; set; }
        public int IdFuelType { get; set; }

        public CarDto(int id, int mileage, string color, string generation, DateTime productionDate, bool isAvailable, int idFuelType)
        {
            Id = id;
            Mileage = mileage;
            Color = color;
            Generation = generation;
            ProductionDate = productionDate;
            IsAvailable = isAvailable;
            IdFuelType = idFuelType;
        }
    }
}
