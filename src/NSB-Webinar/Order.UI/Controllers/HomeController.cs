using System;
using System.Threading;
using System.Web.Mvc;
using NServiceBus;
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
            var orderId = Guid.NewGuid();
            Thread.Sleep(3000);
            return Json(new OrderModel { Name = name, OrderId = orderId });
        }
    }
}