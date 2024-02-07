using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeMon_Grupp.Api;

namespace PokeMon_Grupp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async void OnGet()
        {
            ApiCaller APi = new ApiCaller();
            await APi.GetPokemon("arbok");
        }
    }
}
