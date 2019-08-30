using PlanetDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlanetDatabase.Controllers
{
    [Route("api/[controller]")]
    public class PlanetsController : Controller
    {
    //planets store in a fixed array inside controller
    //In a bigger application a query to  database or external source could be required
    Planet[] planets = new Planet[]
    {
      new Planet { Id = 1, Name = "Mercury", DistanceSun = 57.91, Unit = "million km"},
      new Planet { Id = 2, Name = "Venus", DistanceSun = 108.2,  Unit = "million km" },
      new Planet { Id = 3, Name = "Earth", DistanceSun = 149.6,  Unit = "million km" },
      new Planet { Id = 4, Name = "Mars", DistanceSun = 227.9,  Unit = "million km"},
      new Planet { Id = 5, Name = "Jupiter", DistanceSun = 778.5,  Unit = "million km"},
      new Planet { Id = 6, Name = "Satun", DistanceSun = 1.429,  Unit = "billion km"},
      new Planet { Id = 7, Name = "Uranus", DistanceSun = 2.877, Unit = "billion km"},
      new Planet { Id = 8, Name = "Neptune", DistanceSun = 4.498, Unit = "billion km"},

    };

      // GET: api/<controller>
      [HttpGet("/api/planets/")]
    public IEnumerable<Planet> Get()
    {
        return planets;
    }

 
    }
}
