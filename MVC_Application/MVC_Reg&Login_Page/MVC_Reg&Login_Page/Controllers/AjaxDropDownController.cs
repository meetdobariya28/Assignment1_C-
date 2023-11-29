using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Reg_Login_Page.Controllers
{
    public class AjaxDropDownController : Controller
    {
        // GET: AjaxDropDown
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetCountries()
        {
            var Countries = new List<string>();
            Countries.Add("Canada");
            Countries.Add("India");
            Countries.Add("USA");
            return Json(Countries, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public JsonResult GetStates(string country)
        {
            var States = new List<string>();
            if (!string.IsNullOrWhiteSpace(country))
            {
                if (country.Equals("Canada"))
                {
                    States.Add("Toronto");
                    States.Add("Brampton");
                }
                if (country.Equals("India"))
                {
                    States.Add("Surat");
                    States.Add("Mumbai");
                }
                if (country.Equals("USA"))
                {
                    States.Add("New York");
                    States.Add("Texas");
                }
            }
            return Json(States, JsonRequestBehavior.AllowGet);
        }
    }
}