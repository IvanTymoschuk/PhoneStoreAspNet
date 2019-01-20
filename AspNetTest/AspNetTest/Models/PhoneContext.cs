using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetTest.Models
{
    public class PhoneContext:DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }

    }

    //public class PhoneDbInitializer : DropCreateDatabaseAlways<PhoneContext>
    //{
    //    protected override void Seed(PhoneContext db)
    //    {
    //        db.Phones.Add(new Phone() {Name = "Iphone XS", Price = 1200, Qty = 554});
    //        db.Phones.Add(new Phone() { Name = "Samsung Galaxy", Price = 980, Qty = 400 });

    //        base.Seed(db);
    //    }
    //}
}