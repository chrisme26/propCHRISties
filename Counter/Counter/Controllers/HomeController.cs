using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Counter.Models;

namespace Counter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult incCount(int cnt)
        {
            try
            {                
                using (var db = new CounterContext())
                {
                    tblCounter tbl = new tblCounter();
                    tbl.Count = cnt;

                    db.tblCounters.Add(tbl);
                    db.SaveChanges();
                }
            }
            catch (Exception e) { throw e; }

            return Json("Success", JsonRequestBehavior.AllowGet);
        }   
    }
}