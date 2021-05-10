using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class TarifsContext: DbContext
    {
      
        public TarifsContext(): base("TarifsContext")
        { }
        public DbSet<Tarif> Tarifs { get; set; }

    }
}