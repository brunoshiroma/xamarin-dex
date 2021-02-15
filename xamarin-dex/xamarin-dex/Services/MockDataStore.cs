using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xamarin_dex.Models;

namespace xamarin_dex.Services
{
    public class MockDataStore : IDataStore<Pokemon>
    {
        readonly List<Pokemon> items;

        public MockDataStore()
        {
            items = new List<Pokemon>()
            {
                new Pokemon {
                    NationalNumber = 1,
                    Name = "Bulbasauro",
                    ImagesUrl = new Dictionary<string, IEnumerable<string>>(){
                        {
                            "Fire Red", new List<string>{ "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/001.png" }
                        }
                    }
                },
                new Pokemon {
                    NationalNumber = 2,
                    Name = "Ivysauro",
                    ImagesUrl = new Dictionary<string, IEnumerable<string>>(){
                        { 
                            "Fire Red",  new  List<string>{"https://assets.pokemon.com/assets/cms2/img/pokedex/detail/002.png" }
                        }
                    }
                }
            };
        }

        public async Task<bool> AddItemAsync(Pokemon item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Pokemon item)
        {
            var oldItem = items.Where((Pokemon arg) => arg.NationalNumber == item.NationalNumber).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Pokemon arg) => arg.NationalNumber == int.Parse(id)).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Pokemon> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.NationalNumber == int.Parse(id)));
        }

        public async Task<IEnumerable<Pokemon>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}