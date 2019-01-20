using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetTest.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
    }
}