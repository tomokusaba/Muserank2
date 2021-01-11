using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using Muserank2.Models.Muse;

namespace Muserank2.Data
{
  public partial class MuseContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public MuseContext(DbContextOptions<MuseContext> options):base(options)
    {
    }

    public MuseContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Muserank2.Models.Muse.Chart>().HasKey(table => new {
          table.NENDO, table.GENRE, table.HYOKA_NUM, table.KYOKU_NAME, table.AUTHOR_NAME, table.HOUR, table.MINUTE, table.SECOND, table.MEMBER, table.FILE_SIZE
        });


        this.OnModelBuilding(builder);
    }


    public DbSet<Muserank2.Models.Muse.Chart> Charts
    {
      get;
      set;
    }
  }
}
