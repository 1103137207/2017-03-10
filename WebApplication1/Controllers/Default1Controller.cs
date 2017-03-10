using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class Default1Controller : Controller
    {
        // GET: Default1
        public ActionResult Index()
        {
            Models.OrdersService orderService = new Models.OrdersService();
            var order = orderService.GetOrdersById("111");
            ViewBag.CustId=order.CustId;
            ViewBag.CustName = order.CustName;
            return View();
        }
    }
}