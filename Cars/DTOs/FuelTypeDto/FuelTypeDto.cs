using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.DTOs
{
    public record FuelTypeDto
    {
        public int id { get; init; }
        public string name { get; set; }

        public FuelTypeDto(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
