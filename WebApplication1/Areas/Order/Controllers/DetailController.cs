using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Areas.Order.Controllers
{
    public class DetailController : Controller
    {
        // GET: Order/Detail
        public ActionResult Index()
        {
            ViewBag.Desc = "Hello Order";
            return View();
        }

        public ActionResult InsertOrder()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult InsertOrder(Models.Orders order)
        {
            return View("Index");
        
    }
    }
}