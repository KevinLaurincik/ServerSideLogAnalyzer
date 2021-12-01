#pragma checksum "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\Pages\ImportLog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "533e25aafa0d2ce822690d51bdfaa110a63e8e54"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ServerSideLogAnalyzer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\_Imports.razor"
using ServerSideLogAnalyzer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\_Imports.razor"
using ServerSideLogAnalyzer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\Pages\ImportLog.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\Pages\ImportLog.razor"
using ServerSideLogAnalyzer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\Pages\ImportLog.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\Pages\ImportLog.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Importlog")]
    public partial class ImportLog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "C:\Users\kevin\Desktop\LogAnalyzer\ServerSideLogAnalyzer\Pages\ImportLog.razor"
       

    async Task ShowAlert()
    {
        await JsRunTime.InvokeVoidAsync("createAlert");
    }

    private void HandleValidSubmit()
    {
        // Process the valid form
    }

    public class InfoInsert
    {
        [Range(1, 5000000, ErrorMessage = "Zadali ste zlé ID, Povolený rozsah je od 1 po 5000000")]
        public int idValueInsert { get; set; }

        [Required(ErrorMessage = "The Job Start Date field is Required")]
        public DateTime dateValueInsert { get; set; }

        [Required]
        [StringLength(2000, ErrorMessage = "Vaš popis prekročil hranicu 2000 znakov!")]
        public string discriptionValueInsert { get; set; }
    }

    public class InfoUpdate
    {
        [Range(1, 5000000, ErrorMessage = "Zadali ste zlé ID, Povolený rozsah je od 1 po 5000000")]
        public int idValueUpdate { get; set; }

        [Required(ErrorMessage = "The Job Start Date field is Required")]
        public DateTime dateValueUpdate { get; set; }

        [Required]
        [StringLength(2000, ErrorMessage = "Vaš popis prekročil hranicu 2000 znakov!")]
        public string discriptionValueUpdate { get; set; }
    }

    public class InfoDelete
    {
        [Range(1, 5000000, ErrorMessage = "Zadali ste zlé ID, Povolený rozsah je od 1 po 5000000")]
        public int idValueDelete { get; set; }
    }

    List<LogModel> logs;

    private async Task InsertData()
    {
        string sql = "insert into logs (idLogs, Date, Discription) values (@idLogs, @Date, @Discription);";

        await _data.SaveData(sql, new { idLogs = _info.idValueInsert, Date = _info.dateValueInsert, Discription = _info.discriptionValueInsert }, _config.GetConnectionString("default"));

        await OnInitializedAsync();

    }

    private async Task UpdateData()
    {
        string sql = "update logs set Date = @Date,Discription = @Discription where idLogs = @idLogs";

        await _data.SaveData(sql, new { idLogs = _infoUpdate.idValueUpdate, Date = _infoUpdate.dateValueUpdate, Discription = _infoUpdate.discriptionValueUpdate }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    private async Task DeleteData()
    {
        string sql = "delete from logs where idLogs = @idLogs";

        await _data.SaveData(sql, new { idLogs = _infoDelete.idValueDelete }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        string sql = "select * from logs";
        logs = await _data.LoadData<LogModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
    }

    private InfoInsert _info { get; set; } = new InfoInsert();
    private InfoUpdate _infoUpdate { get; set; } = new InfoUpdate();
    private InfoDelete _infoDelete { get; set; } = new InfoDelete();

    //alert of what type should inputs be

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRunTime { get; set; }
    }
}
#pragma warning restore 1591
