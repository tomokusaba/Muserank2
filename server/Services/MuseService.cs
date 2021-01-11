using Radzen;
using System;
using System.Web;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Data;
using System.Text.Encodings.Web;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using Muserank2.Data;

namespace Muserank2
{
    public partial class MuseService
    {
        private readonly MuseContext context;
        private readonly NavigationManager navigationManager;

        public MuseService(MuseContext context, NavigationManager navigationManager)
        {
            this.context = context;
            this.navigationManager = navigationManager;
        }

        public void Reset() => context.ChangeTracker.Entries().Where(e => e.Entity != null).ToList().ForEach(e => e.State = EntityState.Detached);

        public async Task ExportChartsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/muse/charts/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/muse/charts/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportChartsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/muse/charts/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/muse/charts/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnChartsRead(ref IQueryable<Models.Muse.Chart> items);

        public async Task<IQueryable<Models.Muse.Chart>> GetCharts(Query query = null)
        {
            var items = context.Charts.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnChartsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnChartCreated(Models.Muse.Chart item);
        partial void OnAfterChartCreated(Models.Muse.Chart item);

        public async Task<Models.Muse.Chart> CreateChart(Models.Muse.Chart chart)
        {
            OnChartCreated(chart);

            context.Charts.Add(chart);
            context.SaveChanges();

            OnAfterChartCreated(chart);

            return chart;
        }

        partial void OnChartDeleted(Models.Muse.Chart item);
        partial void OnAfterChartDeleted(Models.Muse.Chart item);

        public async Task<Models.Muse.Chart> DeleteChart(string nendo, string genre, decimal? hyokaNum, string kyokuName, string authorName, decimal? hour, decimal? minute, decimal? second, decimal? member, decimal? fileSize)
        {
            var itemToDelete = context.Charts
                              .Where(i => i.NENDO == nendo && i.GENRE == genre && i.HYOKA_NUM == hyokaNum && i.KYOKU_NAME == kyokuName && i.AUTHOR_NAME == authorName && i.HOUR == hour && i.MINUTE == minute && i.SECOND == second && i.MEMBER == member && i.FILE_SIZE == fileSize)
                              .FirstOrDefault();

            if (itemToDelete == null)
            {
               throw new Exception("Item no longer available");
            }

            OnChartDeleted(itemToDelete);

            context.Charts.Remove(itemToDelete);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(itemToDelete).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterChartDeleted(itemToDelete);

            return itemToDelete;
        }

        partial void OnChartGet(Models.Muse.Chart item);

        public async Task<Models.Muse.Chart> GetChartByNendoAndGenreAndHyokaNumAndKyokuNameAndAuthorNameAndHourAndMinuteAndSecondAndMemberAndFileSize(string nendo, string genre, decimal? hyokaNum, string kyokuName, string authorName, decimal? hour, decimal? minute, decimal? second, decimal? member, decimal? fileSize)
        {
            var items = context.Charts
                              .AsNoTracking()
                              .Where(i => i.NENDO == nendo && i.GENRE == genre && i.HYOKA_NUM == hyokaNum && i.KYOKU_NAME == kyokuName && i.AUTHOR_NAME == authorName && i.HOUR == hour && i.MINUTE == minute && i.SECOND == second && i.MEMBER == member && i.FILE_SIZE == fileSize);

            var itemToReturn = items.FirstOrDefault();

            OnChartGet(itemToReturn);

            return await Task.FromResult(itemToReturn);
        }

        public async Task<Models.Muse.Chart> CancelChartChanges(Models.Muse.Chart item)
        {
            var entityToCancel = context.Entry(item);
            entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
            entityToCancel.State = EntityState.Unchanged;

            return item;
        }

        partial void OnChartUpdated(Models.Muse.Chart item);
        partial void OnAfterChartUpdated(Models.Muse.Chart item);

        public async Task<Models.Muse.Chart> UpdateChart(string nendo, string genre, decimal? hyokaNum, string kyokuName, string authorName, decimal? hour, decimal? minute, decimal? second, decimal? member, decimal? fileSize, Models.Muse.Chart chart)
        {
            OnChartUpdated(chart);

            var itemToUpdate = context.Charts
                              .Where(i => i.NENDO == nendo && i.GENRE == genre && i.HYOKA_NUM == hyokaNum && i.KYOKU_NAME == kyokuName && i.AUTHOR_NAME == authorName && i.HOUR == hour && i.MINUTE == minute && i.SECOND == second && i.MEMBER == member && i.FILE_SIZE == fileSize)
                              .FirstOrDefault();
            if (itemToUpdate == null)
            {
               throw new Exception("Item no longer available");
            }
            var entryToUpdate = context.Entry(itemToUpdate);
            entryToUpdate.CurrentValues.SetValues(chart);
            entryToUpdate.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterChartUpdated(chart);

            return chart;
        }
    }
}
