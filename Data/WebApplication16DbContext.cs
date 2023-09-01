using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication16.Models;

namespace WebApplication16.Data
{
    public class WebApplication16DbContext : DbContext
    {
        public WebApplication16DbContext (DbContextOptions<WebApplication16DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication16.Models.Task> Task { get; set; } = default!;
    }
}
