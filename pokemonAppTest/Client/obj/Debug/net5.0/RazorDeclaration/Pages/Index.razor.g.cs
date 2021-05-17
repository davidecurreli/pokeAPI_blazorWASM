// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace pokemonAppTest.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\_Imports.razor"
using pokemonAppTest.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\_Imports.razor"
using pokemonAppTest.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Index.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Index.razor"
       
    List<PokemonList> pokemons = new List<PokemonList>();

    private string pokemonFetchEndpoint = "https://pokeapi.co/api/v2/pokemon";

    private int counter = 1;

    protected override async Task OnInitializedAsync()
    {
        var res = await HttpClient.GetFromJsonAsync<PokemonFetchList>(pokemonFetchEndpoint);
        pokemons = res.Results.ToList<PokemonList>();
    }

    public static string GetPokemonImage(string pokemonUrl)
    {
        string imageEndpoint = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/";
        string imageExtension = ".png";

        string pokemonID = GetPokemonID(pokemonUrl);

        pokemonID = String.Concat(pokemonID, imageExtension);

        return String.Concat(imageEndpoint, pokemonID);
    }

    public static string GetPokemonID(string url)
    {
        string subStr = url.Substring(url.IndexOf("pokemon/") + 8);
        string pokemonID = subStr.Remove(subStr.Length - 1, 1);

        return pokemonID;
    }

    public static string FormatString(string str)
    {
        string formattedString = char.ToUpper(str.First()) + str.Substring(1).ToLower();

        return formattedString;
    }

    protected void RedirectDetails(string url)
    {
        string pokemonID = GetPokemonID(url);
        navigationManager.NavigateTo($"/details/{pokemonID}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591