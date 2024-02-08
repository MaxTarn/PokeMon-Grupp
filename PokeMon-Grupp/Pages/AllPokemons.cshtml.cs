using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeMon_Grupp.Database;

namespace PokeMon_Grupp.Pages
{
	public class AllPokemonsModel : PageModel
	{
		private readonly AppDbContext _context;


		public AllPokemonsModel(AppDbContext context)
		{
			_context = context;
		}
		public static List<string> AllGen1Pokemons = new();
		public void OnGet()
		{
			int length = _context.Pokemon.ToList().Count();

		}

	}
}
