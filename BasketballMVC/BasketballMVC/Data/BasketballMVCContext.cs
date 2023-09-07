using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BasketballMVC.Models;

namespace BasketballMVC.Data
{
    public class BasketballMVCContext : DbContext
    {
        public BasketballMVCContext (DbContextOptions<BasketballMVCContext> options)
            : base(options)
        {
        }

        public DbSet<BasketballMVC.Models.Raptors> Raptors { get; set; } = default!;
    }
}
