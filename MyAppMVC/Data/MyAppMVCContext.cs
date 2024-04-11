using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyAppMVC.Models;

namespace MyAppMVC.Data
{
    public class MyAppMVCContext : DbContext
    {
        public MyAppMVCContext (DbContextOptions<MyAppMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MyAppMVC.Models.Movie> Movie { get; set; } = default!;
    }
}
