using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Order.UI.Models;

namespace Order.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Order(string name)
        {
            Thread.Sleep(3000);
            return Json(new OrderModel { Name = name, OrderId = Guid.NewGuid() });
        }
    }
}