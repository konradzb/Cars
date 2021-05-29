using System;
using System.Collections.Generic;

//Car Rental model
namespace Cars.Model
{
    public record CarRental
    {
        public int Id { get; init; }
        public DateTime RentalTimeStart { get; set; }
        public DateTime RentalTimeEnd { get; set; }
        public double Price { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }

        public CarRental(int id,  DateTime rentalTimeStart, DateTime rentalTimeEnd, double price, int userId, int carId)
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

