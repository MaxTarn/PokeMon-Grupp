using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeMon_Grupp.Api;
using PokeMon_Grupp.Managers;
using PokeMon_Grupp.Model;


namespace PokeMon_Grupp.Pages
{
    public class DetailsModel : PageModel
    {

        public int MyProperty { get; set; }
        public PokemonModel? Pokemon { get; set; }
        public async Task OnGet(string pokemonName)
        {
            ApiCaller ApiCalls = new ApiCaller();
            Pokemon = await ApiCalls.GetPokemon(pokemonName);
            Console.WriteLine(Pokemon.name);
            PokemonManager.AllPokemonsChosen.Add(Pokemon);



        }
    }
}
