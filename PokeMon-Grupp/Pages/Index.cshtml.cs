using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeMon_Grupp.Api;
using PokeMon_Grupp.Model;


namespace PokeMon_Grupp.Pages
{
	public class IndexModel : PageModel
	{
		public string? ErrorMessage { get; set; }
		public enum PokemonGen1;

		public async Task<PokemonModel> OnGet()
		{
			try
			{
				PokemonModel result = await new ApiCaller().GetPokemonData("name");

=======
				// Pokemon = result.Pokemon;
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
		}
	}
>>>>>>> master
}
