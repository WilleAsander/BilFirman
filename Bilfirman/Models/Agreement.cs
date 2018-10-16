using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bilfirman.Models
{
    public class Agreement
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Car Car { get; set; }
        public Customer Customer { get; set; }
    }
}