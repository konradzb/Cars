using System;
using System.ComponentModel.DataAnnotations;

//CarEditDto is almost the same like CarInputDto,
//but it's still a good practise to use them both,
//In this case, the diffrence is that in editDto, 
//variables are not required
namespace Cars.Dtos
{
    public record CarEditDto
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

        public CarEditDto(int mileage, string color, string generation, DateTime productionDate, bool isAvailable, int idFuelType)
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

