using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.UnitTestCases.Controllers;
using Practice.UnitTestCases.Business;
using System.Web.Mvc;

namespace UnitTestProject1
{
	/// <summary>
	/// Summary description for EmployeCntrlTest
	/// </summary>
	[TestClass]
	public class EmployeCntrlTest
	{

		EmployeeController employeeController = new EmployeeController();
		Employee emp = new Employee();
		public EmployeCntrlTest()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first test in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

		[TestMethod]
		public void Checking_Insert_Integration()
		{
			
			
			emp.Name = "sravani";
			emp.Address = "Eluru";
			emp.Description="sravani";
			bool expected = true;
			var actionresult = employeeController.Create(emp);
			JsonResult json = (JsonResult)actionresult;
			var orginal = json.Data;
			Assert.AreEqual(expected, orginal);

			//
			// TODO: Add test logic here
			//
		}

		[TestMethod]
		public void Checking_update_Integration()
		{

			emp.Id = 3;
			emp.Name = "sravani2";
			emp.Address = "eluru2";
			emp.Description = "sravani2";
			bool expected = true;
			var actionresult = employeeController.Create(emp);
			JsonResult json = (JsonResult)actionresult;
			var orginal = json.Data;
			Assert.AreEqual(expected, orginal);

			//
			// TODO: Add test logic here
			//
		}

		[TestMethod]
		public void Checking_Delete_Integration()
		{


			emp.Id = 1;
			
			bool expected = true;
			var actionresult = employeeController.Delete(emp.Id);
			JsonResult json = (JsonResult)actionresult;
			var orginal = json.Data;
			Assert.AreEqual(expected, orginal);

			//
			// TODO: Add test logic here
			//
		}
	}
}
