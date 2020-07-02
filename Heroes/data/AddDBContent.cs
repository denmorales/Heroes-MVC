using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heroes.Models;
using Microsoft.EntityFrameworkCore;

namespace Heroes.data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        public DbSet<Player> player { get; set; }
        public DbSet<Club> club { get; set; }
}
}
