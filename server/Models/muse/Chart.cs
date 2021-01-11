using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muserank2.Models.Muse
{
  [Table("CHART", Schema = "SYSTEM")]
  public partial class Chart
  {
    [Key]
    public string NENDO
    {
      get;
      set;
    }
    [Key]
    public string GENRE
    {
      get;
      set;
    }
    [Key]
    public decimal HYOKA_NUM
    {
      get;
      set;
    }
    [Key]
    public string KYOKU_NAME
    {
      get;
      set;
    }
    [Key]
    public string AUTHOR_NAME
    {
      get;
      set;
    }
    [Key]
    public decimal HOUR
    {
      get;
      set;
    }
    [Key]
    public decimal MINUTE
    {
      get;
      set;
    }
    [Key]
    public decimal SECOND
    {
      get;
      set;
    }
    [Key]
    public decimal MEMBER
    {
      get;
      set;
    }
    [Key]
    public decimal FILE_SIZE
    {
      get;
      set;
    }
  }
}
