using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Repositories.FuelType
{
    using Cars.Model;
    public interface IFuelTypeDao
    {
        List<FuelType> getAllFuelNames();
        FuelType getFuelType(int id);
    }
}
