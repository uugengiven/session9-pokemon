using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Session9Pokemon.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gym { get; set; }
        public virtual List<Catch> Catches { get; set; }
    }

    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }

    public class Catch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TrainerId { get; set; }
        public int PokemonId { get; set; }
        public virtual Pokemon Pokemon { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
