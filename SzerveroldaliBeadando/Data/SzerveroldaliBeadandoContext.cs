using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SzerveroldaliBeadando.Models;

namespace SzerveroldaliBeadando.Data
{
    public class SzerveroldaliBeadandoContext : DbContext
    {
        public SzerveroldaliBeadandoContext (DbContextOptions<SzerveroldaliBeadandoContext> options)
            : base(options)
        {
        }

        public DbSet<SzerveroldaliBeadando.Models.Movie> Movie { get; set; } = default!;
    }
}
