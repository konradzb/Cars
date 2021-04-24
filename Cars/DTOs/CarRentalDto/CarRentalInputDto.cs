using System;
using System.ComponentModel.DataAnnotations;

//User passes ths object to create a new Car Object into Data Base
namespace Cars.Dtos
{
    public record CarRentalInputDto
    {
        [Required]
        [Range(0, 9999999)]
        public int ClientId { get; set; }
        [Required]
        [Range(0, 9999999)]
        public int CarId { get; set; }
        [Required]
        [Range(0, 9999999)]
        public int EmployeeId { get; set; }
        [Required]
        public DateTime RentalTimeStart { get; set; }
        [Required]
        public DateTime RentalTimeEnd { get; set; }
        [Required]
        [Range(0, 9999999)]
        public float Price { get; set; }

        public CarRentalInputDto(int clientId, int carId, int employeeId, DateTime rentalTimeStart, DateTime rentalTimeEnd, float price)
        {
            ClientId = clientId;
            CarId = carId;
            EmployeeId = employeeId;
            RentalTimeStart = rentalTimeStart;
            RentalTimeEnd = rentalTimeEnd;
            Price = price;
        }
    }
}
