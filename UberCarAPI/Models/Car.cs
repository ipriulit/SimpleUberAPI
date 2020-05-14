using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UberCarAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Plate { get; set; }
        public int FabricationYear { get; set; }
        public bool IsLuxe { get; set; }
        public bool HasAc { get; set; }
        public string UberCategory { get; set; }
    }
}
