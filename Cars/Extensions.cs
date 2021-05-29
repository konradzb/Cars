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
                car.ModelId,
                car.Mileage,
                car.Color,
                car.ProductionDate,
                car.IsAvailable,
                car.PricePerDay
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
        public static UserDto AsDto(this User user)
        {
            return new UserDto
            {
                id = user.id,
                name = user.name,
                surname = user.surname,
                dateOfBirth = user.dateOfBirth,
                position = user.position
            };
        }
        public static FuelTypeDto AsDto(this FuelType fuel)
        {
            FuelTypeDto fuelType = new FuelTypeDto(
                 fuel.id,
                 fuel.name
             );
            return fuelType;
        }
        public static ModelDto AsDto(this Model.Model model)
        {
            ModelDto item = new ModelDto(
                model.Id,
                model.BrandId,
                model.Type,
                model.Name,
                model.Power,
                model.FuelTypeid,
                model.CarDriveid
           );
            return item;
        }
        public static CarDriveDto AsDto(this CarDrive carDrive)
        {
            CarDriveDto item = new CarDriveDto(
                carDrive.Id,
                carDrive.Name
            );
            return item;
        }
    }
}
