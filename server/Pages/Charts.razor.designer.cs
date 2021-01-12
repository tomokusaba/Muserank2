using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Muserank2.Models.Muse;
using Microsoft.EntityFrameworkCore;

namespace Muserank2.Pages
{
    public partial class ChartsComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected MuseService Muse { get; set; }
        protected RadzenGrid<Muserank2.Models.Muse.Chart> grid0;

        protected int filesize { get; set; } = 256;
        protected int kyokusu { get; set; } = 20;

        protected string seachprm { get; set; } = "";
        protected string seachprm2 { get; set; } = "";
        protected int hoshiH { get; set; } = 800;

        string _search;
        protected string search
        {
            get
            {
                return _search;
            }
            set
            {
                if (!object.Equals(_search, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "search", NewValue = value, OldValue = _search };
                    _search = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Muserank2.Models.Muse.Chart> _getChartsResult;
        protected IEnumerable<Muserank2.Models.Muse.Chart> getChartsResult
        {
            get
            {
                return _getChartsResult;
            }
            set
            {
                if (!object.Equals(_getChartsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getChartsResult", NewValue = value, OldValue = _getChartsResult };
                    _getChartsResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            if (string.IsNullOrEmpty(search)) {
                search = "";
            }

            var museGetChartsResult = await Muse.GetCharts(new Query() { Filter = $@"i => i.NENDO.Contains(@0) || i.GENRE.Contains(@1) || i.KYOKU_NAME.Contains(@2) || i.AUTHOR_NAME.Contains(@3)", FilterParameters = new object[] { search, search, search, search } });
            getChartsResult = museGetChartsResult;
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Muse.ExportChartsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "NENDO,GENRE,HYOKA_NUM,KYOKU_NAME,AUTHOR_NAME,HOUR,MINUTE,SECOND,MEMBER,FILE_SIZE" }, $"Charts");

            }

            if (args?.Value == "xlsx")
            {
                await Muse.ExportChartsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "NENDO,GENRE,HYOKA_NUM,KYOKU_NAME,AUTHOR_NAME,HOUR,MINUTE,SECOND,MEMBER,FILE_SIZE" }, $"Charts");

            }
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var museDeleteChartResult = await Muse.DeleteChart($"{data.NENDO}", $"{data.GENRE}", data.HYOKA_NUM, $"{data.KYOKU_NAME}", $"{data.AUTHOR_NAME}", data.HOUR, data.MINUTE, data.SECOND, data.MEMBER, data.FILE_SIZE);
                    if (museDeleteChartResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception museDeleteChartException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete Chart" });
            }
        }
    }
}
