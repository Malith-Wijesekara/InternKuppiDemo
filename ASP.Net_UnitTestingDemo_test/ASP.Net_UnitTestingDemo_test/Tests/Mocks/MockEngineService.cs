﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Net_UnitTestingDemo_test.Tests.Mocks
{
	public class MockEngineService
	{
		private int Horspower;
		public bool EngineStart(int KeyID)
		{
			if (KeyID.Equals(123))
				return true;
			else
				return false;
		}
	}
}