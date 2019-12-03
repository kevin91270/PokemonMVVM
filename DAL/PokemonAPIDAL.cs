using Newtonsoft.Json;
using PokemonMVVM.Model;
using PokemonMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PokemonMVVM.DAL
{
    public class PokemonAPIDAL
    {
        const string LOADAL_URL = "https://pokeapi.co/api/v2/pokemon/?limit=151";
        public static async Task<List<Pokemons>> LoadPokemons()
        {
            WebClient wc = new WebClient();
            byte[] data = await wc.DownloadDataTaskAsync(new Uri(LOADAL_URL));
            string json = Encoding.UTF8.GetString(data);
            PokemonsApiResult result = JsonConvert.DeserializeObject<PokemonsApiResult>(json);

            return result.Results;
        }

        public static async Task<Pokemons> LoadPokemon(string Url)
            {
                WebClient wc = new WebClient();
                byte[] data = await wc.DownloadDataTaskAsync(new Uri(Url));
                string json = Encoding.UTF8.GetString(data);
                Pokemons result = JsonConvert.DeserializeObject<Pokemons>(json);

                return result; 
            }
    }

}

