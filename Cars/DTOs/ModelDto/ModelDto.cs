using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Dtos
{
    public record ModelDto
    {
        public int Id { get; init; }
        public int BrandId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int IdFuelType { get; set; }  // 1-petrol, 2-diesel, 3-gas, 4-electric
        public int IdCarDrive { get; set; }  // 0-FWD, 1-RWD, 2-AWD

        public ModelDto(int id, int brandId, string type, string name, int power, int idFuelType, int idCarDrive)
        {
            Id = id;
            BrandId = brandId;
            Type = type;
            Name = name;
            Power = power;
            IdFuelType = idFuelType;
            IdCarDrive = idCarDrive;
        }
    }
}
