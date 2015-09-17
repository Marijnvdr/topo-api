using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopografieAPI.Repositories;

namespace TopografieAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

             var db = new NatureElementsRepository();
             var item = db.NatureElements.Where(x => x.NatureId == 1).FirstOrDefault();
             
            if (item == null) 
            {
                ViewBag.Test = "NOT FOUND";
            }
            else
            {
                ViewBag.Test = "YES, FOUND: " + item.Name;
            }
            

            return View();
        }
    }
}
