using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//User passes ths object to create a new Model object into Data Base
namespace Cars.Dtos
{
    public record ModelInputDto
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
        [Range(0, 3)]
        public int IdFuelType { get; set; }
        [Required]
        [Range(0, 3)]
        public int IdCarDrive { get; set; }

        public ModelInputDto(int brandId, string type, string name, int power, int idFuelType, int idCarDrive)
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
