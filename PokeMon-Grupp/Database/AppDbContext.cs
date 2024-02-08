using Microsoft.EntityFrameworkCore;
using PokeMon_Grupp.Model;

namespace PokeMon_Grupp.Database
{
	public class AppDbContext : DbContext
	{

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) //denna konstruktorn har vi för att kunna finna connectionstring?
		{

		}
		public DbSet<PokemonModel> Pokemon { get; set; }
	}
}
