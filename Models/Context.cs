using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session9Pokemon.Models
{
    public class PokemonDB : DbContext
    {
        public PokemonDB(DbContextOptions<PokemonDB> anything) : base(anything)
        {
        }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Pokemon> Pokemans { get; set; }
        public DbSet<Catch> Catches { get; set; }

    }
}
