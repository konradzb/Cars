using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//User passes this object to edit already existing Model Object
namespace Cars.Dtos
{
    public record ModelEditDto
    {
        [Required]
        [Range(0, 9999999)]
        public int BrandId { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Generation { get; set; }
        [Required]
        [Range(1, 4)]
        public int IdFuelType { get; set; }
        [Required]
        [Range(0, 999)]
        public double Combustion { get; set; }

        public ModelEditDto(int brandId, string type, string name, string generation, int idFuelType, double combustion)
        {
            BrandId = brandId;
            Type = type;
            Name = name;
            Generation = generation;
            IdFuelType = idFuelType;
            Combustion = combustion;
        }

    }
}
