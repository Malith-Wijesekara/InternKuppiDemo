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

			
		public string Drive(EngineService engine, int KeyID)
		{
			if (engine.EngineStart(KeyID))
				return "Ready to drive";
			else
				return "Engine failed";
		}

	}
}