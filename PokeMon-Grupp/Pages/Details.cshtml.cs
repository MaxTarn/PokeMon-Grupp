using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeMon_Grupp.Api;
using PokeMon_Grupp.Database;
using PokeMon_Grupp.Managers;
using PokeMon_Grupp.Model;


namespace PokeMon_Grupp.Pages
{
    public class DetailsModel : PageModel
    {

        private readonly AppDbContext context;
        public int MyProperty { get; set; }
        public PokemonModel? Pokemon { get; set; }
        public DetailsModel(AppDbContext context)
        {
            this.context = context;
        }
        public async Task OnGet(string pokemonName)
        {
            ApiCaller ApiCalls = new ApiCaller();
            Pokemon = await ApiCalls.GetPokemon(pokemonName);

            if (Pokemon != null)
            {
                PokemonModel? pokemonInDatabase = context.Pokemon.ToList().FirstOrDefault(pokemon => pokemon.name == Pokemon.name);
                if (pokemonInDatabase == null)
                {
                    context.Pokemon.Add(Pokemon);
                    context.SaveChanges();
                }

            }

            ////adds the pokemon chsoen to the pokemon chsoen list, and if user has already chosen that pokemon, it does not add the pokemon the the chosen pokemon list
            //PokemonModel? pokemonInList = PokemonManager.AllPokemonsChosen.FirstOrDefault(pokemon => pokemon == Pokemon);
            //if (pokemonInList == null)
            //{
            //    PokemonManager.AllPokemonsChosen.Add(Pokemon);

            //    Pokemon = pokemonInList;




            //}


        }
    }
}
