using System;

namespace Cars.Model
{
	public class Car
	{
		public Guid Id { get; init; }
		public string Name { get; set; }
		public double Price { get; set; }
		public string Producer { get; set; }
		public string DateOfProduction { get; set; }


		public Car(Guid id, string Name, double Price, string Producer, string DateOfProduction)
		{
			this.Id = id;
			this.Name = Name;
			this.Price = Price;
			this.Producer = Producer;
			this.DateOfProduction = DateOfProduction;
		}


	}
}
