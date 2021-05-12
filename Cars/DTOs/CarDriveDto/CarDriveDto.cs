using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Dtos
{
    public record CarDriveDto
    {
        public int Id { get; init; }
        public string Name { get; set; }

        public CarDriveDto(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
