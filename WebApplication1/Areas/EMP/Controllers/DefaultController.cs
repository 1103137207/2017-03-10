using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Areas.EMP.Controllers
{
    public class DefaultController : Controller
    {
        // GET: EMP/Default
        public ActionResult Index()
        {
            ViewBag.Desc="Hello Emp";
            return View();
        }
    }
}