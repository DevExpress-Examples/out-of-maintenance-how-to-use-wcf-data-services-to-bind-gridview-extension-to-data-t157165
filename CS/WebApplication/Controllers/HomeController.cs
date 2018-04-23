using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.Data.WcfLinq;
using WebApplication.NwindServiceReference;

namespace DXWebApplication1.Controllers {
    public class HomeController : Controller {

        northwindEntities db = new northwindEntities(new Uri("http://localhost:60491/WcfDataService1.svc"));

        public ActionResult Index() {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartial() {
            var model = GetWcfDataSource();
            return PartialView("_GridViewPartial", model);
        }

        WcfServerModeSource GetWcfDataSource() {
            return new WcfServerModeSource() {
                KeyExpression = "OrderID",
                Query = db.Orders
                        .Expand(q => q.Customer)
                        .Expand(q => q.Shipper)
            };
        }
    }
}