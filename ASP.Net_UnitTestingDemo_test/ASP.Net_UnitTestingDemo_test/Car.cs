using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.Net_UnitTestingDemo_test.Services;

namespace ASP.Net_UnitTestingDemo_test
{
	public class Car
	{
		private string color { get; set; }
		private int modelNumber { get; set; }
		

		public Car(string color, int modelNumber)
		{
			this.color = color;
			this.modelNumber = modelNumber;
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