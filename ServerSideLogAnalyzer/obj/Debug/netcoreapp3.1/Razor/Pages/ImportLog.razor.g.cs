#pragma checksum "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "322726567d1818fac676c50a4689a807adc6386d"
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
#nullable restore
#line 3 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
using ServerSideLogAnalyzer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Importlog")]
    public partial class ImportLog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/MyStyles/MyStyles.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>Tu nahrajte Log!</h1>\r\n\r\n");
            __builder.AddMarkupContent(2, "<form>\r\n    <label for=\"myfile\">Vyberte súbory:</label>\r\n    <input type=\"file\" id=\"myfile\" name=\"myfile\" multiple><br><br>\r\n    <input type=\"submit\">\r\n</form>\r\n\r\n");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-primary");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                                          InsertData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Insert");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-warning");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                                          UpdateData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-danger");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                                         DeleteData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n\r\n");
#nullable restore
#line 24 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
 if (logs == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.AddMarkupContent(19, "<p><em>Načítava sa...</em></p>\r\n");
#nullable restore
#line 27 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "    ");
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "table");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<thead class=\"thead-dark\">\r\n            <tr>\r\n                <th scope=\"col\">#ID</th>\r\n                <th scope=\"col\">Date & Time</th>\r\n                <th scope=\"col\">Discription</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(25, "tbody");
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 40 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
             foreach (var item in logs)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "th");
            __builder.AddAttribute(31, "scope", "row");
            __builder.AddContent(32, 
#nullable restore
#line 43 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                                     item.idLogs

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 44 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                         item.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 45 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                         item.Discription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 47 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 50 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "\r\n\r\n\r\n");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "container");
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col");
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.AddMarkupContent(54, "<h1>Insert</h1>\r\n            ");
            __builder.AddMarkupContent(55, "<p>\r\n                idValue\r\n            </p>\r\n            ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "value", 
#nullable restore
#line 61 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                           idValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(58, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                                              (EventArgs) => { SetValueId(EventArgs.Value.ToString()); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n            ");
            __builder.AddMarkupContent(60, "<p>\r\n                dateValue\r\n            </p>\r\n            ");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "value", 
#nullable restore
#line 66 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                           dateValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(63, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                                                (EventArgs) => { SetValueDate(EventArgs.Value.ToString()); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n            ");
            __builder.AddMarkupContent(65, "<p>\r\n                discriptionValue\r\n            </p>\r\n            ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "value", 
#nullable restore
#line 71 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                           discriptionValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(68, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                                                       (EventArgs) => { SetValueDiscription(EventArgs.Value.ToString()); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "col");
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.AddMarkupContent(74, "<h1>Update</h1>\r\n            ");
            __builder.AddMarkupContent(75, "<p>\r\n                idValue\r\n            </p>\r\n            ");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "value", 
#nullable restore
#line 78 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                           idValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(78, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                                              (EventArgs) => { SetValueId(EventArgs.Value.ToString()); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\r\n            ");
            __builder.AddMarkupContent(80, "<p>\r\n                dateValue\r\n            </p>\r\n            ");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "value", 
#nullable restore
#line 83 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                           dateValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(83, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                                                (EventArgs) => { SetValueDate(EventArgs.Value.ToString()); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\r\n            ");
            __builder.AddMarkupContent(85, "<p>\r\n                discriptionValue\r\n            </p>\r\n            ");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "value", 
#nullable restore
#line 88 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                           discriptionValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(88, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                                                       (EventArgs) => { SetValueDiscription(EventArgs.Value.ToString()); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n        ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "col");
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.AddMarkupContent(94, "<h1>Delete</h1>\r\n            ");
            __builder.AddMarkupContent(95, "<p>\r\n                idValue\r\n            </p>\r\n            ");
            __builder.OpenElement(96, "input");
            __builder.AddAttribute(97, "value", 
#nullable restore
#line 95 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                           idValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(98, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
                                              (EventArgs) => { SetValueId(EventArgs.Value.ToString()); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Users\kevin\Desktop\ServerSideLogAnalyzer\Pages\ImportLog.razor"
       
    string idValue;
    string discriptionValue = "";
    string dateValue = "";

    private void SetValueDiscription(string Value)
    {
        discriptionValue = Value;
    }

    private void SetValueDate(string Value)
    {
        dateValue = Value;
    }

    private void SetValueId(string Value)
    {
        idValue = Value;
    }

    List<LogModel> logs;

    private async Task InsertData()
    {
        string sql = "insert into logs (idLogs, Date, Discription) values (@idLogs, @Date, @Discription);";

        await _data.SaveData(sql, new { idLogs = int.Parse(idValue), Date = dateValue, Discription = discriptionValue }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    private async Task UpdateData()
    {
        string sql = "update logs set Date = @Date,Discription = @Discription where idLogs = @idLogs";

        await _data.SaveData(sql, new { idLogs = int.Parse(idValue), Date = dateValue, Discription = discriptionValue }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    private async Task DeleteData()
    {
        string sql = "delete from logs where idLogs = @idLogs";

        await _data.SaveData(sql, new { idLogs = int.Parse(idValue) }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        string sql = "select * from logs";
        logs = await _data.LoadData<LogModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591