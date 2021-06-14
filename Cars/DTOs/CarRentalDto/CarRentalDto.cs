using System;

//API returns this object instead of CarRental itself
//It's good practise and reduces chances of the app breaking down
namespace Cars.Dtos
{
    public record CarRentalDto
    {
        public int Id { get; init; }
        public DateTime RentalTimeStart { get; set; }
        public DateTime RentalTimeEnd { get; set; }
        public double Price { get; set; }

        public int UserId { get; set; }
        public int CarId { get; set; }

        public CarRentalDto(int id, DateTime rentalTimeStart, DateTime rentalTimeEnd, double price, int userId, int carId)
        {
            Id = id;
            RentalTimeStart = rentalTimeStart;
            RentalTimeEnd = rentalTimeEnd;
            Price = price;
            UserId = userId;
            CarId = carId;
        }
    }
}

