using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCApp2.Models;

namespace MVCApp2.Data
{
    public class MVCApp2Context : DbContext
    {
        public MVCApp2Context (DbContextOptions<MVCApp2Context> options)
            : base(options)
        {
        }

        public DbSet<MVCApp2.Models.Movie> Movie { get; set; } = default!;
    }
}
