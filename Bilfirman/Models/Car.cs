using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bilfirman.Models
{
    public class Car
    {
        public string Registration { get; set; }
        public string Model { get; set; } //Leaf, 3, i3
        public string Manufacturer { get; set; } //Nissan, Tesla, BMW
        public string Color { get; set; } //Red, Pink, Blue
        public bool Rented { get; set; }
    }
}