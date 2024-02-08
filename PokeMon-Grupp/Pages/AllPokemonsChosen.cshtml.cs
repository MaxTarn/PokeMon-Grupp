using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using PokeMon_Grupp.Database;
using PokeMon_Grupp.Managers;
using PokeMon_Grupp.Model;


namespace PokeMon_Grupp.Pages
{
    public class AllPokemonsChosenModel : PageModel
    {
        private readonly AppDbContext _appDbContext;

        public AllPokemonsChosenModel(AppDbContext context)
        {
            _appDbContext = context;
        }
        public List<PokemonModel>? Pokemons { get; set; }
        public IActionResult OnGet()
        {
            if (_appDbContext.Pokemon.ToList().Count() <= 0)
            {
                return BadRequest();
            }
            Pokemons = _appDbContext.Pokemon.ToList();
            return Page();
        }
    }
}
