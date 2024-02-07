using System.Text.Json.Serialization;
using Newtonsoft.Json;
using PokeMon_Grupp.Model;

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
        //public async Task<Root> MakeCall(string url)
        //{
        //    HttpResponseMessage response = await Client.GetAsync(url);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        string json = await response.Content.ReadAsStringAsync();

        //        Root? result = JsonConvert.DeserializeObject<Root>(json);
        //        if (result != null)
        //        {
        //            return result;
        //        }

        //    }

        //    throw new HttpRequestException();
        //}

        public async Task<string?> GetPokemonData(string pokemonName)
        {
            HttpResponseMessage response = await Client.GetAsync(pokemonName);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return json;
            }
            return null;
        }

        public async Task<PokemonModel?> GetPokemon(string pokemonName)
        {
            HttpResponseMessage response = await Client.GetAsync(pokemonName);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                PokemonModel? pokemon = JsonConvert.DeserializeObject<PokemonModel>(json);
                Console.Write(pokemon);
                return pokemon;

            }

            return null;

        }

    }
}
