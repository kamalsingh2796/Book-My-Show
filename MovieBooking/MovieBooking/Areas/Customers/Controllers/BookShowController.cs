using System;
using BOL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieBooking.Areas.Customers.Controllers
{
    public class BookShowController : Controller
    {
        //
        // GET: /Customers/BookShow/
        public ActionResult Index()
        {
            MovieBookingEntities db = new MovieBookingEntities();
            ViewBag.StateId = new SelectList(db.States, "StateId", "StateName");
            return View();
        }
        [HttpGet]
        public JsonResult GetCities(string id)
        {
            List<SelectListItem> Cities = new List<SelectListItem>();
            switch (id)
            {
                case "1":
                    Cities.Add(new SelectListItem { Text = "Select", Value = "0" });
                    Cities.Add(new SelectListItem { Text = "Rohtak", Value = "1" });
                    Cities.Add(new SelectListItem { Text = "Faridabad", Value = "2" });
                    Cities.Add(new SelectListItem { Text = "Bhiwani", Value = "3" });
                    Cities.Add(new SelectListItem { Text = "Hissar", Value = "4" });
                    break;
                case "2":
                    break;
                case "3":
                    break;
            }
            return Json(new SelectList(Cities, "Value", "Text"));
        }
    }
}