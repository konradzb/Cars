using System;
using System.ComponentModel.DataAnnotations;

//User passes ths object to create a new Car Object into Data Base
namespace Cars.Dtos
{
    public record CarRentalInputDto
    {
        [Required]
        public DateTime RentalTimeStart { get; set; }
        [Required]
        public DateTime RentalTimeEnd { get; set; }
        [Required]
        [Range(0, 9999999)]
        public double Price { get; set; }
        [Required]
        [Range(0, 9999999)]
        public int UserId { get; set; }
        [Required]
        [Range(0, 9999999)]
        public int CarId { get; set; }

        public CarRentalInputDto(DateTime rentalTimeStart, DateTime rentalTimeEnd, double price, int userId, int carId)
        {
            RentalTimeStart = rentalTimeStart;
            RentalTimeEnd = rentalTimeEnd;
            Price = price;
            UserId = userId;
            CarId = carId;
        }
    }
}
