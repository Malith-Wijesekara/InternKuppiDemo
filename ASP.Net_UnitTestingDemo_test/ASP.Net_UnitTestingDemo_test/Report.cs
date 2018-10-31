using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Net_UnitTestingDemo_test.Services
{
	public class Report
	{
		public string InspectorName { get; set; }
		public int carID { get; set; }
		
		public bool IsEnginChecked { get; set; }
		public bool IsBreakTested { get; set; }
		
	}
}