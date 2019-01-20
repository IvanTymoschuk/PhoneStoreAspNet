using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetTest.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int IdPhone { get; set; }
        public DateTime DateOrder  { get; set; }
        public string Name { get; set; }

    }
}