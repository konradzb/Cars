using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Model
{
    public record FuelType
    {
        public int id { get; init; }
        public string name { get; set; }
        public List<Model> Models { get; set; }

        public FuelType(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}