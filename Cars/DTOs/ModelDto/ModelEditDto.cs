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
        [Range(0, 20000)]
        public int Power { get; set; }
        [Required]
        [Range(0, 5)]
        public int IdFuelType { get; set; }
        [Required]
        [Range(0, 5)]
        public int IdCarDrive { get; set; }

        public ModelEditDto(int brandId, string type, string name, int power, int idFuelType, int idCarDrive)
        {
            BrandId = brandId;
            Type = type;
            Name = name;
            Power = power;
            IdFuelType = idFuelType;
            IdCarDrive = idCarDrive;
        }
    }
}
