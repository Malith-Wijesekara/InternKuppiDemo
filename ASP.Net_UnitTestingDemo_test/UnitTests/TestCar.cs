using System;
using ASP.Net_UnitTestingDemo_test;
using ASP.Net_UnitTestingDemo_test.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class TestCar
	{
		
		private static Car car = new Car("red",121);
		[TestMethod]
		public void Drive_shouldReturnString()
		{
			
			var returnObject = car.inspect(123);
			Assert.IsInstanceOfType(returnObject, typeof(Report));
			Assert.IsNotNull(returnObject);
			Assert.AreEqual(returnObject.InspectorName, "Jone Blix");
			//Assert.IsNull(returnObject);
		}
	}
}
