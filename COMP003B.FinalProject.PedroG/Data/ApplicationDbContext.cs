using COMP003B.FinalProject.PedroG.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.FinalProject.PedroG.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options) { }

		public DbSet<Car> Cars { get; set; }
		public DbSet<Booking> Bookings { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Mechanic> Mechanics { get; set; }
		public DbSet<Service> Services { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Service>()
				.HasKey(s => s.Id);
		}

	}
}
