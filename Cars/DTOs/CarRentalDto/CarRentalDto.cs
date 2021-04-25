using System;

//API returns this object instead of CarRental itself
//It's good practise and reduces chances of the app breaking down
namespace Cars.Dtos
{
    public record CarRentalDto
    {
        public int Id { get; init; }
        public int ClientId { get; set; }
        public int CarId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime RentalTimeStart { get; set; }
        public DateTime RentalTimeEnd { get; set; }
        public double Price { get; set; }

        public CarRentalDto(int id, int clientId, int carId, int employeeId, DateTime rentalTimeStart, DateTime rentalTimeEnd, double price)
        {
            Id = id;
            ClientId = clientId;
            CarId = carId;
            EmployeeId = employeeId;
            RentalTimeStart = rentalTimeStart;
            RentalTimeEnd = rentalTimeEnd;
            Price = price;
        }
    }
}

