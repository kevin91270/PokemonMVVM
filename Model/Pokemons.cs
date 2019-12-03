using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PokemonMVVM.Model
{
    public class PokemonsApiResult
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<Pokemons> Results { get; set; }
    }

    public class Pokemons
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public ImageData Sprites { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
    public class ImageData
    {
        public string front_default { get; set; }
    }
}
