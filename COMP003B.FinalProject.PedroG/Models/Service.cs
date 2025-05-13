using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.PedroG.Models
{
	public class Service
	{
		[Key]
		public int Id { get; set; }

		public string ServiceName { get; set; }

		[Required]
		public string ServiceVersion { get; set; }

		public string Price { get; set; }
	}
}
