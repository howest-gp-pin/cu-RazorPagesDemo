using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesDemo.Models;

namespace RazorPagesDemo.Data
{
    public class RazorPagesDemoContext : DbContext
    {
        public RazorPagesDemoContext (DbContextOptions<RazorPagesDemoContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesDemo.Models.Movie> Movie { get; set; } = default!;
    }
}
