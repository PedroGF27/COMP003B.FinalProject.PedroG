using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.PedroG.Models
{
	public class Mechanic
	{
		public int MechanicId { get; set; }

		public string MechanicName { get; set; }

		public string MechanicDescription { get; set; }

		[Required]
		[EmailAddress]
		public string MechanicEmail { get; set; }

		[Required]
		public string MechanicPhone { get; set; }
	}
}
