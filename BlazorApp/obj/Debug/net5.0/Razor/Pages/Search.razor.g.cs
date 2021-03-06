#pragma checksum "C:\Users\gswil\BlazorApp\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3a15658697f536cacfae6aef1495f36f942a44b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gswil\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gswil\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gswil\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gswil\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gswil\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gswil\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gswil\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gswil\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gswil\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gswil\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddContent(0, 
#nullable restore
#line 3 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
 uName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
                           uName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => uName = __value, uName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<h1></h1>\r\n\r\n");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-primary");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
                                          UserSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
                                          LoadResults

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Load Table");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n<h2></h2>");
#nullable restore
#line 40 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
 if(Globals.count<1)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<h3 class=\"p-3 text-center\">No Results Found</h3>");
#nullable restore
#line 43 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
 if(Globals.count>0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "container");
            __builder.AddMarkupContent(20, "<h3 class=\"p-3 text-center\">Search Results Sorted by Followers</h3>\r\n    ");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, "Search results: ");
            __builder.AddContent(23, 
#nullable restore
#line 48 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
                        Globals.count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "class", "table table-striped table-bordered");
            __builder.AddMarkupContent(27, "<thead><tr><th>Avatar</th>\r\n                <th>User Name</th>\r\n                <th>Page</th>\r\n                <th>ID</th></tr></thead>\r\n        ");
            __builder.OpenElement(28, "tbody");
#nullable restore
#line 59 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
             if(Globals.count>0)
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
             for (int i = 0; i < Globals.count; i++)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "tr");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "img");
            __builder.AddAttribute(32, "src", "https://avatars.githubusercontent.com/u/" + (
#nullable restore
#line 64 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
                                                                       Globals.idList[i]

#line default
#line hidden
#nullable disable
            ) + "?v=4");
            __builder.AddAttribute(33, "width", "50");
            __builder.AddAttribute(34, "height", "50");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "b");
            __builder.AddContent(38, 
#nullable restore
#line 67 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
                        Globals.userList[i]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "href", "https://github.com/" + (
#nullable restore
#line 69 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
                                                 Globals.userList[i]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, 
#nullable restore
#line 69 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
                                                                       Globals.userList[i]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(44, "\'s Github Page ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 70 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
                     Globals.idList[i]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "text-center");
#nullable restore
#line 78 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
     if(Globals.pageNum>1)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "class", "btn btn-primary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
                                              prevPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(53, "Previous Page");
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(54, "<b>Page:</b>");
            __builder.AddContent(55, 
#nullable restore
#line 82 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
                 Globals.pageNum

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "class", "btn btn-primary");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
                                              nextPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(60, "Next Page");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\gswil\BlazorApp\Pages\Search.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\gswil\BlazorApp\Pages\Search.razor"
       
    private int count { get; set; }
    private string uName { get; set; } = "GitHub User Name";
    private List<string> userList { get; set; } = new List<string>();
    private int i { get; set; } = Globals.index;

    private async void UserSearch()
    {

        List<string> userList = await Program.userSearchAsync(uName);
    }
    private void LoadResults()
    {
        Program.genList();

    }
    private void nextPage()
    {
        Globals.pageNum=Globals.pageNum+1;
    }
    private void prevPage()
    {
        Globals.pageNum=Globals.pageNum-1;
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
