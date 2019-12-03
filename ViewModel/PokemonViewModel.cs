using PokemonMVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PokemonMVVM.ViewModel
{
    class PokemonViewModel : INotifyPropertyChanged
    {
         
        
            private List<Pokemons> pokemons;
            public PokemonViewModel()
            {
                LoadPokemons();
            }

            private async void LoadPokemons()
            {
                Pokemons = await DAL.PokemonAPIDAL.LoadPokemons();
            }

            public List<Pokemons> Pokemons
            {
                get { return pokemons; }
                set
                {
                    pokemons = value;
                    OnPropertyChange("Pokemons");
                }
            }
            private Pokemons selectedPokemon;

            public  Pokemons SelectedPokemon
            {
                get { return selectedPokemon; }
                set
                {
                    selectedPokemon = value;
                    LoadImages(value.Url);
                    OnPropertyChange("SelectedPokemon");
                    
                }
            }

        private Pokemons loadedPokemon;

        public Pokemons LoadedPokemon
        {
            get { return loadedPokemon; }
            set { loadedPokemon = value;
                OnPropertyChange("LoadedPokemon");
            }
        }


        private async void LoadImages(string Url)
        {
            LoadedPokemon = await DAL.PokemonAPIDAL.LoadPokemon(Url);
        }

        public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChange(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
       
    }

