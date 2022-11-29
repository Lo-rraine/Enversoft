using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EverCleanDbSystem.Models;

namespace EverCleanDbSystem.Data
{
    public class EverCleanDbSystemContext : DbContext
    {
        public EverCleanDbSystemContext (DbContextOptions<EverCleanDbSystemContext> options)
            : base(options)
        {
        }

        public DbSet<EverCleanDbSystem.Models.Supplier> Supplier { get; set; } = default!;
    }
}
