using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeMon_Grupp.Managers;
using PokeMon_Grupp.Model;


namespace PokeMon_Grupp.Pages
{
    public class AllPokemonsChosenModel : PageModel
    {
        public List<PokemonModel>? Pokemons { get; set; } = PokemonManager.AllPokemonsChosen;
        public void OnGet()
        {

        }
    }
}
