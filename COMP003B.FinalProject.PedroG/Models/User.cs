using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.PedroG.Models
{
	public class User
	{

		public int UserId { get; set; }

		[Required]
		public string UserName { get; set; }

		[Required]
		public int Phone { get; set; }

		[Required]
		public string Email { get; set; }

		//public ICollection<Booking> Bookings { get; set; }
	}
}
