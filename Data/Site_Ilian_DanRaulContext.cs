using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Site_Ilian_DanRaul.Models;

namespace Site_Ilian_DanRaul.Data
{
    public class Site_Ilian_DanRaulContext : DbContext
    {
        public Site_Ilian_DanRaulContext (DbContextOptions<Site_Ilian_DanRaulContext> options)
            : base(options)
        {
        }

        public DbSet<Site_Ilian_DanRaul.Models.ListaAnimecs> ListaAnimecs { get; set; } = default!;

        public DbSet<Site_Ilian_DanRaul.Models.Statut> Status { get; set; }

        public DbSet<Site_Ilian_DanRaul.Models.Titlu> Titlu { get; set; }

        public DbSet<Site_Ilian_DanRaul.Models.Nota> Nota { get; set; }
    }
}
