using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeMon_Grupp.Model;

namespace PokeMon_Grupp.Pages
{
	public class DetailsModel : PageModel
	{
		public int MyProperty { get; set; }
		public void OnGet(PokemonModel pokemon)
		{

		}
	}
}
