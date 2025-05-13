using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.PedroG.Models
{
	public class Car
	{
		public int CarId { get; set; }

		[Required]
		public string CarName { get; set; }

		[Required]
		[StringLength(100, ErrorMessage = "Must be valid Model")]
		public string CarModel { get; set; }

		[Required]
		[Range(1900, 2030, ErrorMessage = "Must be a valid Year (1900-2030)")]
		public int CarYear { get; set; }

		[Required]
		[StringLength(10, ErrorMessage = "Must be a valid license plate")]
		public string LicensePlate { get; set; }

		//public ICollection<Booking> Bookings { get; set; }
	}
}
