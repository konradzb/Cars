using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Repositories.FuelType
{
    using Cars.Model;
    public class FakeFuelTypeDao : IFuelTypeDao
    {
        public List<FuelType> fuelTypes = new List<FuelType> { new FuelType(1, "Petrol"), new FuelType(2, "Diesel"), new FuelType(3, "Gas"), new FuelType(4, "Electric") };
        public List<FuelType> getAllFuelNames()
        {
            return this.fuelTypes;
        }

        public FuelType getFuelType(int id)
        {
            return this.fuelTypes.Find(fuel => id == fuel.id);
        }
    }
}
