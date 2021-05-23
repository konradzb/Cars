using System;
using System.ComponentModel.DataAnnotations;

//User passes ths object to create a new Car Object into Data Base
namespace Cars.Dtos
{
    public record CarInputDto
    {
        [Required]
        [Range(0, 9999999)]
        public int ModelId { get; set; }
        [Required]
        [Range(0, 9999999)]
        public int Mileage { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public DateTime ProductionDate { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
        [Required]
        [Range(0, 9999999)]
        public double PricePerDay { get; set; }

        public CarInputDto(int modelId, int mileage, string color, DateTime productionDate, bool isAvailable, double pricePerDay)
        {
            ModelId = modelId;
            Mileage = mileage;
            Color = color;
            ProductionDate = productionDate;
            IsAvailable = isAvailable;
            PricePerDay = pricePerDay;
        }
    }
}

