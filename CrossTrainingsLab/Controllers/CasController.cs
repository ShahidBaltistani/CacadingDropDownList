using CrossTrainingsLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrossTrainingsLab.Controllers
{
    public class CasController : Controller
    {
        CrossTrainingsLabContext db = new CrossTrainingsLabContext();

        // GET: Cas
        public ActionResult Index()
        {
            List<Country> CountryList = db.Countries.ToList();
            ViewBag.CountryList = new SelectList(CountryList, "CountryId", "CountryName");
            return View();
        }
        public JsonResult GetCityList(int CountryId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<City> cities = db.Cities.Where(x => x.CountryId == CountryId).ToList();

            return Json(cities, JsonRequestBehavior.AllowGet);
            
        }
    }
}