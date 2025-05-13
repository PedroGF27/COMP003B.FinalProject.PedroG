using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.PedroG.Models
{
	public class Car
	{
		public int CarId { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Model { get; set; }

		[Required]
		public int Year { get; set; }

		[Required]
		public string LicensePlate { get; set; }

		//public ICollection<Booking> Bookings { get; set; }
	}
}
