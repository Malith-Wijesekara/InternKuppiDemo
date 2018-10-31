using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_test.Controllers;

namespace UnitTestProject
{
	[TestClass]
	public class UnitTest1
	{
		private static CarFactoryController Carcontroller = null;
		public static CarFactoryController GetController()
		{
			if (Carcontroller == null)
			{
				Carcontroller = new CarFactoryController();
			}
				return Carcontroller;

		}


		[TestMethod]
		public void TestMethod1()
		{
			var ID = 123;
			var returnObject = car.inspect(ID);

		}
	}
}
