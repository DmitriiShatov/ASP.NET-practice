using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Bike> Bikes { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
