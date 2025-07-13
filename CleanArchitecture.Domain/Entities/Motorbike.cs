using CleanArchitecture.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Motorbike:Entity
    {
        public string Brand { get; set; }=default!;
        public string Model { get; set; } = default!;
        public decimal Price { get; set; }
        public int Power { get; set; }
    }
}
