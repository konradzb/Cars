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
        public string Generation { get; set; }
        public int IdFuelType { get; set; }
        public double Combustion { get; set; }  // spalanie na 100 km

        public ModelDto(int id, int brandId, string type, string name, string generation, int idFuelType, double combustion)
        {
            Id = id;
            BrandId = brandId;
            Type = type;
            Name = name;
            Generation = generation;
            IdFuelType = idFuelType;
            Combustion = combustion;
        }
    }
}
