using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Bike
    {
        public int BikeId { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int StyleId { get; set; }
        public Style Style { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int Price { get; set; }
    }
}
