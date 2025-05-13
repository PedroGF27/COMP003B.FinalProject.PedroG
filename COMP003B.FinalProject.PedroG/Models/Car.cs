using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.PedroG.Models
{
	public class Car
	{
		public int CarId { get; set; }

		[Required]
		public string CarName { get; set; }

		[Required]
		public string CarModel { get; set; }

		[Required]
		public int CarYear { get; set; }

		[Required]
		public string LicensePlate { get; set; }

		//public ICollection<Booking> Bookings { get; set; }
	}
}
