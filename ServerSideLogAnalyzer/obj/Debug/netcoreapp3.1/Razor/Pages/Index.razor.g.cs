#pragma checksum "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e61c76f2c62e2e6f2d0e424d2ae4c174f48dbc1"
// <auto-generated/>
#pragma warning disable 1591
namespace ServerSideLogAnalyzer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\_Imports.razor"
using ServerSideLogAnalyzer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\_Imports.razor"
using ServerSideLogAnalyzer.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/MyStyles/MyStyles.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1 id=\"introductionheader\">Vitajte</h1>\r\n");
            __builder.AddMarkupContent(2, "<p id=\"introductiontext\">Táto webová aplikácia je zameraná na prácu s aplikačnými logmi, analýzu dát, ktoré nám aplikačné logy poskytujú, a taktiež následnú interpretáciu dát v rôznych formách.</p>\r\n\r\n<hr>\r\n<hr>\r\n");
            __builder.AddMarkupContent(3, "<h3>Čo obsahujú aplikačné logy ? </h3>\r\n");
            __builder.AddMarkupContent(4, "<p>Aplikačné logy obsahujú informácie o všetkých akciách a zmenách v danom sledovanom systéme.</p>\r\n\r\n\r\n<hr>\r\n<hr>\r\n");
            __builder.AddMarkupContent(5, "<h3>Na čo sú užitočné aplikačné logy ? </h3>\r\n");
            __builder.AddMarkupContent(6, "<p>\r\n    Môžeme z nich zistiť kto a kedy urobil akú konkrétnu akciu v systéme.\r\n    Dáta z logu nám umožňujú nájsť a následne odstrániť chyby v aplikáciách. Odhalovať bezpečnostné incidenty a predchádzať únikom dát.\r\n</p>\r\n\r\n\r\n<hr>\r\n<hr>\r\n");
            __builder.AddMarkupContent(7, "<h3>Aká je štruktúra aplikačného logu ? </h3>\r\n");
            __builder.AddMarkupContent(8, "<ul type=\"square\" class=\"textunderline\">\r\n    <li>ID uživateľa alebo systému</li>\r\n    <li>Čas zmeny alebo akcie</li>\r\n    <li>Popis zmeny alebo akcie</li>\r\n    <li>Nejaké bonusové dodatočné informácie k zmene alebo akcií</li>\r\n</ul>\r\n\r\n<hr>\r\n<hr>\r\n");
            __builder.AddMarkupContent(9, "<h5>Viac informácií o aplikačných logoch môžete nájsť na: <a href=\"https://www.sumologic.com/glossary/log-analysis/\">ENGInfo</a></h5>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
