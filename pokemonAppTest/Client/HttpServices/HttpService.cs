using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace pokemonAppTest.Client.HttpServices
{
    public class HttpService
    {
        private readonly string pokemonFetchEndpoint = "https://pokeapi.co/api/v2/pokemon";
        public async Task<PokemonFetchList> GetPokemonList()
        {
                HttpClient http = new();
                return await http.GetFromJsonAsync<PokemonFetchList>(pokemonFetchEndpoint);
        }

        public async Task<PokemonDetails> GetPokemonDetails(string pokemonID)
        {
            HttpClient http = new();
            return await http.GetFromJsonAsync<PokemonDetails>($"{pokemonFetchEndpoint}/{pokemonID}");
        }
    }

}
