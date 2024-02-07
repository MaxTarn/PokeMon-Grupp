using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PokeMon_Grupp.Pages
{
	public class AllPokemonsModel : PageModel
	{
		public static List<string> AllGen1Pokemons = new();
		public void OnGet()
		{
		}
	}
}
