using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Reg_Login_Page.Models;

namespace MVC_Reg_Login_Page.Controllers
{
    public class RegistrationController : Controller
    {
        MyDataDBEntities db = new MyDataDBEntities();
        // GET: Registration
        public ActionResult Index()
        {
            var dataList = db.Registrations.ToList();
            return View(dataList);
        }
        [HttpGet]
        public ActionResult Registration()
        {
            Registration reg = new Registration();

            List<Registration> users = new List<Registration>
            {
                new Registration(){ City="Brampton" },
                new Registration(){ City="Toronto" },
                new Registration(){ City="Ottawa" },
                new Registration(){ City="Osawa" },
                new Registration(){ City="Missi" },

            };

            ViewData["Users"] = users;

            //var cityList = new List<SelectListItem>();

            //cityList.Add(new SelectListItem
            //{
            //    Text = "Brampton",
            //    Value = "1"
            //});
            //cityList.Add(new SelectListItem
            //{
            //    Text = "Toronto",
            //    Value = "2"
            //});
            //cityList.Add(new SelectListItem
            //{
            //    Text = "Ottawa",
            //    Value = "3"
            //});
            //cityList.Add(new SelectListItem
            //{
            //    Text = "Mississauga",
            //    Value = "4"
            //});
            //cityList.Add(new SelectListItem
            //{
            //    Text = "Osawa",
            //    Value = "5"
            //});

            //reg.CityList = cityList;

            return View();
        }

        [HttpPost]
        public ActionResult Registration(Registration r)
        {
            db.Registrations.Add(r);
            db.SaveChanges();
            ViewBag.Message = "Data Inserted Successfully...";
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
             return View();
        }
        [HttpPost]
        public ActionResult Login(Registration r)
        {
            var log = db.Registrations.Where(
                x => x.FirstName.Equals(r.FirstName) && 
                x.email.Equals(r.email) && 
                x.Password.Equals(r.Password)).FirstOrDefault();
                //Registration.Where(a => a.FirstName.Equals(r.FirstName) && r.Password.Equals(r.Password)).FirstOrDefault();

            if(log != null)
            {
                return RedirectToAction("Index", "Registration");
            }else
            {
                return RedirectToAction("Login", "Registration");
            }
            return View();
        }

        
        
        // GET: Registration/Details/5
        public ActionResult Details(int id)
        {
            var data = db.Registrations.Where(x => x.UserID == id).FirstOrDefault();
            return View(data);
        }



        [HttpGet]// GET: Registration/Edit/5
        public ActionResult Edit(int id)
        {
            var data = db.Registrations.Where(x => x.UserID == id ).FirstOrDefault();
            return View(data);
        }

        // POST: Registration/Edit/5
        [HttpPost]
        public ActionResult Edit(Registration r)
        {
           var data = db.Registrations.Where(x => x.UserID == r.UserID).FirstOrDefault();

           if(data != null)
            {
                data.FirstName = r.FirstName;
                data.LastName = r.LastName;
                data.Age = r.Age;
                data.Gender = r.Gender;
                data.City = r.City;
                data.email = r.email;
                data.Password = r.Password;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: Registration/Delete/5
        public ActionResult Delete(int id)
        {
            var data = db.Registrations.Where(x => x.UserID == id).FirstOrDefault();
            db.Registrations.Remove(data);
            db.SaveChanges();
            ViewBag.Message = "Data has been Deleted Successfully...";
            return RedirectToAction("Index");
        }

    }
}
