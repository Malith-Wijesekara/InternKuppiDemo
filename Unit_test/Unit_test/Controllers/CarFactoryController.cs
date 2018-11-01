using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unit_test.Helpers;

namespace Unit_test.Controllers
{
    public class CarFactoryController
    {
		private string color { get; set; }
		private int modelNumber { get; set; }


		public CarFactoryController(string color, int modelNumber)
		{
			this.color = color;
			this.modelNumber = modelNumber;
		}

		public Report GetReport(int ID)
		{
			var report = new Report();
			report.carID = ID;
			report.InspectorName = "Jone Blix";
			report.IsEnginChecked = false;
			report.IsBreakTested = true;


			return report;
		}
		public void FunctionWithException()
		{
			throw new NotImplementedException();
		}
	}
}