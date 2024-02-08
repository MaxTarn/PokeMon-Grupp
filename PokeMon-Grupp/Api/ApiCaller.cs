using Newtonsoft.Json;
using PokeMon_Grupp.Model;
using System.Text.Json.Serialization;

namespace PokeMon_Grupp.Api
{
    public class ApiCaller
    {

        public HttpClient Client { get; set; }

        public ApiCaller()
        {
            Client = new();
            //Lägg till en basadress till klienten, eftersom alla calls komemr gå till den sidan.
            Client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");
        }




        public async Task<PokemonModel?> GetPokemon(string pokemonName)
        {
            pokemonName = pokemonName.ToLower().Trim().TrimEnd().TrimStart();
            HttpResponseMessage response = await Client.GetAsync(pokemonName);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                PokemonModel? pokemon = JsonConvert.DeserializeObject<PokemonModel>(json);
                pokemon.id = 0;
                Console.Write(pokemon);
                return pokemon;

            }

            return null;

        }

    }
}
