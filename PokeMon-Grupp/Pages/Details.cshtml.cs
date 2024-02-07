using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PokeMon_Grupp.Pages
{
    public class DetailsModel : PageModel
    {

        public void OnGet(string pokemonName)
        {
            Console.WriteLine(pokemonName);
        }
    }
}
