using Cars.Dtos;
using Cars.Model;
using Cars.DTOs;

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
        public static BrandDto AsDto(this Brand brand)
        {
            BrandDto item = new BrandDto(
                brand.Id,
                brand.Name,
                brand.Founder,
                brand.Origin,
                brand.Headquarter,
                brand.EstablishmentDate
            );
            return item;
        }

        public static CarRentalDto AsDto(this CarRental carRental)
        {
            CarRentalDto item = new CarRentalDto(
                carRental.Id,
                carRental.ClientId,
                carRental.CarId,
                carRental.EmployeeId,
                carRental.RentalTimeStart,
                carRental.RentalTimeEnd,
                carRental.Price
            );
            return item;
        }
        public static EmployeeDto AsDto(this Employee employee)
        {
            return new EmployeeDto
            {
                id = employee.id,
                name = employee.name,
                surname = employee.surname,
                dateOfBirth = employee.dateOfBirth,
                position = employee.position
            };
        }
        public static ModelDto AsDto(this Model.Model model)
        {
            ModelDto item = new ModelDto(
                model.Id,
                model.BrandId,
                model.Type,
                model.Name,
                model.Power,
                model.IdFuelType,
                model.IdCarDrive
           );
            return item;
        }
    }
}
