using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Session9Pokemon.Models;

namespace Session9Pokemon.Controllers
{
    [Route("game")]
    public class GameController : Controller
    {
        public PokemonDB db;

        public GameController(PokemonDB context)
        {
            db = context;
        }

        [Route("{id}")]
        [Route("index/{id}")]
        public IActionResult Index(int id)
        {
            var trainer = db.Trainers.Where(trainer => trainer.Id == id).FirstOrDefault();
            // var trainer db.Trainers.Find(id);

            // hey, if trainer is null, they
            // typed in a bad number
            if(trainer == null)
            {
                return NotFound();
            }
            return View(trainer);
        }

        [Route("grass")]
        public IActionResult Encounter()
        {
            var pokemans = db.Pokemans.ToList();
            Random myrandommaker = new Random();
            var randomNumber = myrandommaker.Next(0, pokemans.Count);

            return View(pokemans[randomNumber]);
        }
    }
}