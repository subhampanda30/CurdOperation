using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CurdOperation.Models;

namespace CurdOperation.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext (DbContextOptions<MyAppContext> options)
            : base(options)
        {
        }

        public DbSet<CurdOperation.Models.Product> Product { get; set; } = default!;
    }
}
