using System;
using System.ComponentModel.DataAnnotations;

//User passes ths object to create a new Car Object into Data Base
namespace Cars.Dtos
{
    public record CarInputDto
    {
        [Required]
        [Range(0, 4999999)]
        public int Mileage { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Generation { get; set; }
        [Required]
        public DateTime ProductionDate { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
        [Required]
        [Range(1, 3)]
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

