namespace PokeMon_Grupp.Model
{
    public class PokemonModel
    {
        public int id { get; set; }

        public string name { get; set; }

        public int height { get; set; }
        public int weight { get; set; }



        public static List<string> AllGen1Pokemons;

        static PokemonModel()
        {
            AllGen1Pokemons = new();
            foreach (string Pokemon in System.Enum.GetValues(typeof(Enum.Enums.PokemonGen1)))
            {
                AllGen1Pokemons.Add(Pokemon);
            }
        }

    }
}
