using Cars.Dtos;
using Cars.Model;

//This class is created to save lines of code and make it more readable
//If you you have piece of code witch have to be reapeted over and over again, 
//put it here and make it a static method
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