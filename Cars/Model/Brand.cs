using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Model
{
    public record Brand
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public string Founder { get; set; }
        public string Origin { get; set; }  // country
        public string Headquarter { get; set; } // city
        public DateTime EstablishmentDate { get; set; }

        public List<Model> Models { get; set; }

        public Brand(int id, string name, string founder, string origin, string headquarter, DateTime establishmentDate)
        {
            Id = id;
            Name = name;
            Founder = founder;
            Origin = origin;
            Headquarter = headquarter;
            EstablishmentDate = establishmentDate;
        }
    }
}
