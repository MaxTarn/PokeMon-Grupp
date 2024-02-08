using PokeMon_Grupp.Enum;
using PokeMon_Grupp.Model;

namespace PokeMon_Grupp.Managers
{
    public static class PokemonManager
    {
        public static List<string> AllGen1Pokemons => System.Enum.GetNames(typeof(Enums.PokemonGen1)).ToList();
        public static List<PokemonModel> AllPokemonsChosen = new();
    }
}
