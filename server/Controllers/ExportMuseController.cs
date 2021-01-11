using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Muserank2.Data;

namespace Muserank2
{
    public partial class ExportMuseController : ExportController
    {
        private readonly MuseContext context;

        public ExportMuseController(MuseContext context)
        {
            this.context = context;
        }
        [HttpGet("/export/Muse/charts/csv")]
        [HttpGet("/export/Muse/charts/csv(fileName='{fileName}')")]
        public FileStreamResult ExportChartsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Charts, Request.Query), fileName);
        }

        [HttpGet("/export/Muse/charts/excel")]
        [HttpGet("/export/Muse/charts/excel(fileName='{fileName}')")]
        public FileStreamResult ExportChartsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Charts, Request.Query), fileName);
        }
        [HttpGet("/export/Muse/charts2/csv")]
        [HttpGet("/export/Muse/charts2/csv(fileName='{fileName}')")]
        public FileStreamResult ExportChartsToCSV2(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Charts, Request.Query), fileName);
        }

        [HttpGet("/export/Muse/charts2/excel")]
        [HttpGet("/export/Muse/charts2/excel(fileName='{fileName}')")]
        public FileStreamResult ExportChartsToExcel2(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Charts, Request.Query), fileName);
        }

    }
}
