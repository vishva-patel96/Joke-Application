using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokeApplication.Models;

namespace JokeApplication.Data
{
    public class JokeApplicationContext : DbContext
    {
        public JokeApplicationContext (DbContextOptions<JokeApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<JokeApplication.Models.Joke> Joke { get; set; } = default!;
    }
}
