using System.ComponentModel.DataAnnotations;

namespace PokeMon_Grupp.Model
{

    public class PokemonModel
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; } = null!;

        public int height { get; set; }
        public int weight { get; set; }
    }
}
