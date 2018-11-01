using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_test.Controllers;
using Unit_test.Helpers;

namespace UnitTestProject
{
	[TestClass]
	public class UnitTest1
	{
		private static CarFactoryController carController = null;
		
		[AssemblyInitialize]
		public static void AssemblyInit(TestContext context)
		{
			
			carController = new CarFactoryController("red", 123);		

		}

		[TestMethod]
		public void TestMethod1()
		{
			
			var ID = 123;
			var returnObject = carController.GetReport(ID);
			Assert.IsInstanceOfType(returnObject, typeof(Report));
			Assert.IsNotNull(returnObject);
			//Assert.IsNull(returnObject);
			Assert.AreEqual(returnObject.InspectorName, "Jone Blix");
			Assert.AreEqual(returnObject.carID, ID);
			Assert.IsTrue(returnObject.IsBreakTested);
			Assert.IsFalse(returnObject.IsEnginChecked);
		}
	}
}
