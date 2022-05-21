using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KukBuk.Models;

    public class KukBukContext : DbContext
    {
        public KukBukContext (DbContextOptions<KukBukContext> options)
            : base(options)
        {
        }

        public DbSet<KukBuk.Models.Recipe>? Recipe { get; set; }
    }
