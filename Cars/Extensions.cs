using Cars.Dtos;
using Cars.Model;

namespace Cars.Extensions
{
    public static class Extensions
    {
        public static CarDto AsDto(this Car car)
        {
            CarDto item = new CarDto(
                car.Id,
                car.Mileage,
                car.Color,
                car.Generation,
                car.ProductionDate,
                car.IsAvailable,
                car.IdFuelType
            );
            return item;
        }
    }
}