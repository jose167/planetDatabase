using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetDatabase.Models
{
  public class Planet
  {
 
      public int Id { get; set; }
      public string Name { get; set; }

      public double DistanceSun { get; set; }

      public string Unit { get; set; }
  }
}
