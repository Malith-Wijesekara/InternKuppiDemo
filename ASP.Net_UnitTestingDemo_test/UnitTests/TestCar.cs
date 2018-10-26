using System;
using ASP.Net_UnitTestingDemo_test;
using ASP.Net_UnitTestingDemo_test.Services;
using ASP.Net_UnitTestingDemo_test.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class TestCar
	{
		private static EngineService mockEngineService = new EngineService();
		private static Car car = new Car();
		[TestMethod]
		public void Drive_shouldReturnString()
		{
			var returnObject = car.Drive(mockEngineService, 123);
			Assert.IsInstanceOfType(returnObject, typeof(string));
			Assert.IsNotNull(returnObject);
			//Assert.IsNull(returnObject);
		}
	}
}
