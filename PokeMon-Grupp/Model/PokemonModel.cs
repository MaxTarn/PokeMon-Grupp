namespace PokeMon_Grupp.Model
{
    public class PokemonModel
    {
        public int Id { get; set; }

        public string Name { get; set; }



        public static List<string> AllGen1Pokemons = new List<string>();

        static PokemonModel()
        {
            foreach (string Pokemon in System.Enum.GetValues(typeof(Enum.Enums.PokemonGen1)))
            {
                AllGen1Pokemons.Add(Pokemon);
            }
        }

    }
}
