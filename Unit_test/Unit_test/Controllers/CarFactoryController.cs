using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unit_test.Helpers;

namespace Unit_test.Controllers
{
    public class CarFactoryController : Controller
    {
		private string color { get; set; }
		private int modelNumber { get; set; }
		// GET: CarFactory
		public ActionResult Index()
        {
            return View();
        }

		public Report inspect(int ID)
		{
			var report = new Report();
			report.carID = ID;
			report.InspectorName = "Jone Blix";
			report.IsEnginChecked = true;
			report.IsBreakTested = true;

			return report;
		}

	}
}