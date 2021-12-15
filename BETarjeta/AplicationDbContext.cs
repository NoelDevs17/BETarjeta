using BETarjeta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BETarjeta
{
    public class AplicationDbContext: DbContext

    {
      
      public DbSet<TarjetaCredito>  TarjetaCredito { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
    }
}
