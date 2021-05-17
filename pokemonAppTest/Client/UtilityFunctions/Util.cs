using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokemonAppTest.Client.UtilityFunctions
{
    public class Util
    {
        public string ImageEndpoint { get; set; } = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/";
        public string ImageExtension { get; set; }  = ".png";

        public static string GetPokemonID(string url)
        {
            string subStr = url[(url.IndexOf("pokemon/") + 8)..];
            string pokemonID = subStr.Remove(subStr.Length - 1, 1);

            return pokemonID;
        }

        public static string GetPokemonImage(string pokemonUrl)
        {
            Util url = new();

            string pokemonID = GetPokemonID(pokemonUrl);
            pokemonID = String.Concat(pokemonID, url.ImageExtension);

            return String.Concat(url.ImageEndpoint, pokemonID);
        }

        public static string FormatString(string str)
        {
            if (String.IsNullOrEmpty(str)) return "";

            string formattedString = char.ToUpper(str.First()) + str[1..].ToLower();

            return formattedString;
        }
    }

}
