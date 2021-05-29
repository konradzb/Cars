using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Model
{
    public record CarDrive
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public List<Model> Models { get; set; }

        public CarDrive(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
