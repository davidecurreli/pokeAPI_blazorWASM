namespace BlazorApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
    
    public class PokemonFetchList
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public PokemonList[] Results { get; set; }
    }
    
    public class PokemonList
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class PokemonDetails
    {
        public PokemonDetails() { }
        public PokemonDetails(PokemonAbility[] abilities, string name, PokemonType[] types, int base_experience, int height, int weight)
        {
            Abilities = abilities;
            Name = name;
            Types = types;
            Base_experience = base_experience;
            Height = height;
            Weight = weight;
        }

        public PokemonAbility[] Abilities { get; set; }
        public string Name { get; set; }
        public PokemonType[] Types { get; set; }
        public int Base_experience { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }

    public class PokemonAbility
    {
        public int Slot { get; set; }
        public Ability Ability { get; set; }
    }

    public class Ability
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class PokemonType
    {
        public int Slot { get; set; }
        public Type Type { get; set; }
    }

    public class Type
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}

