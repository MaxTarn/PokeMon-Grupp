using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeMon_Grupp.Api;


namespace PokeMon_Grupp.Pages
{
    public class IndexModel : PageModel
    {
        public string? ErrorMessage { get; set; }
        public enum PokemonGen1;




        public async Task OnGet()
        {
            try
            {
                string result = await new ApiCaller().GetPokemonData("name");

                // Pokemon = result.Pokemon;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            // return null;
        }

        public async Task<string> CallApi(string PokemonName)
        {
            ApiCaller apiCaller = new ApiCaller();
            return await apiCaller.GetPokemonData(PokemonName);
        }
    }

}
