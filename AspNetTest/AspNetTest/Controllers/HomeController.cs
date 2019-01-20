using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetTest.Models;

namespace AspNetTest.Controllers
{
    public class HomeController : Controller
    {
        PhoneContext db = new PhoneContext();

        public ActionResult Index()
        {
            var phones = db.Phones;
            ViewBag.Phones = phones;
            return View();
        }

        public ActionResult Buy()
        {
            int phoneId = Int32.Parse(Request.Params["Id"]);

            var phones = db.Phones;
            var phone = db.Phones.Where(i => i.Id == phoneId).First();


            if (phone.Qty < 1)
            {
                return null;
            }

            phone.Qty--;

            db.Orders.Add(new Order() {DateOrder = DateTime.Now, IdPhone = phoneId, Name = "Alex"});
            db.SaveChanges();

            ViewBag.phone = phone;
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}