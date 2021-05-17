#pragma checksum "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bf358493b825bd66d600e2263fc1b536cffd3d8"
// <auto-generated/>
#pragma warning disable 1591
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
#line 6 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
using HttpServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
using UtilityFunctions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/details/{pokemonID}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "style", "margin-top: 40px; text-align: center;");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "h5");
            __builder.AddAttribute(5, "style", "margin-bottom: 40px;");
            __builder.AddContent(6, 
#nullable restore
#line 11 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
                                                  pokemonDetails.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, @"<thead><tr><th scope=""col"">Pokemon name</th>
                <th scope=""col"">Abilities</th>
                <th scope=""col"">Types</th>
                <th scope=""col"">Base Experience</th>
                <th scope=""col"">Height</th>
                <th scope=""col"">Weight</th></tr></thead>
        ");
            __builder.OpenElement(11, "tbody");
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "th");
            __builder.AddAttribute(14, "scope", "row");
            __builder.AddContent(15, 
#nullable restore
#line 25 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
                                 pokemonDetails.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.OpenElement(18, "ul");
#nullable restore
#line 28 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
                         foreach (var ability in pokemonAbilities)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "li");
            __builder.AddContent(20, 
#nullable restore
#line 30 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
                                 ability.Ability.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "ul");
#nullable restore
#line 36 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
                         foreach (var type in pokemonTypes)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "li");
            __builder.AddContent(25, 
#nullable restore
#line 38 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
                                 type.Type.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 42 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
                     pokemonDetails.Base_experience

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 43 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
                     pokemonDetails.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 44 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
                     pokemonDetails.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n    ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
                                                            RedirectHome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Back to Home!");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\david\source\repos\pokemonAppTest\pokemonAppTest\Client\Pages\Details.razor"
      
    [Parameter]
    public string pokemonID { get; set; }

    private HttpService http = new();

    private PokemonDetails pokemonDetails = new PokemonDetails();
    List<PokemonAbility> pokemonAbilities = new List<PokemonAbility>();
    List<PokemonType> pokemonTypes = new List<PokemonType>();


    protected override async Task OnInitializedAsync()
    {
        try
        {
            var response = await http.GetPokemonDetails(pokemonID);

            pokemonAbilities = response.Abilities.ToList<PokemonAbility>();
            pokemonTypes = response.Types.ToList<PokemonType>();

            pokemonDetails.Base_experience = response.Base_experience;
            pokemonDetails.Name = Util.FormatString(response.Name);
            pokemonDetails.Weight = response.Weight;
            pokemonDetails.Height = response.Height;

        }
        catch (Exception ex)
        {
            navigationManager.NavigateTo($"/error/{ex.Message}");
        }
    }

    protected void RedirectHome()
    {
        navigationManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
