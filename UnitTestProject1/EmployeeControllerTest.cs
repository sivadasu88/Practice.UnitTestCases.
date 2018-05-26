using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.UnitTestCases;
using Practice.UnitTestCases.Controllers;


namespace UnitTestProject1
{
	[TestClass]
	public class EmployeeControllerTest
	{
		[TestMethod]
		public void Create_Checking()
		{
			
			EmployeeController employeeController = new EmployeeController();
			//employeeController.
		}
		[TestMethod]
		public void Testing_Effort_Integration()
		{
			EntityApplicationEntities db = new EntityApplicationEntities();
		
			var entity = db.tbl_Employee;
	        Assert.IsNotNull(entity);
			
		}
		[TestMethod]
		public void Create_Testing_Effort_Integration()
		{
			EmployeeController employeeController = new EmployeeController();
			tbl_Employee original = new tbl_Employee();
			original.Id = 1;
			original.Name = "sravani";
			original.Address = "eluru";
			original.Description = "sravani";

			var expected=employeeController.Create(original);


			JsonResult jsonResult = (JsonResult)expected;
			var model = (tbl_Employee)jsonResult.Data;



			Assert.AreEqual(original, model);

		}
		[TestMethod]
		public void Create_Testing_IsExist_Integration()
		{
			EmployeeController employeeController = new EmployeeController();
			tbl_Employee original = new tbl_Employee();
			original.Id = 2;
			original.Name = "sravani";
			original.Address = "eluru";
			original.Description = "sravani";

			var expected = employeeController.Create(original);


			JsonResult jsonResult = (JsonResult)expected;
			var model = (tbl_Employee)jsonResult.Data;



			Assert.AreSame(original, model);

		}
		[TestMethod]
		public void Create_Testing_Update_Integration()
		{
			EmployeeController employeeController = new EmployeeController();
			tbl_Employee original = new tbl_Employee();
			original.Id = 1;
			original.Name = "sravani1";
			original.Address = "eluru";
			original.Description = "sravani1";

			var expected = employeeController.Create(original);


			JsonResult jsonResult = (JsonResult)expected;
			var model = (tbl_Employee)jsonResult.Data;



			Assert.AreSame(original, model);

		}
		[TestMethod]
		public void Delete_Testing__Interation()
		{
			EmployeeController employeeController = new EmployeeController();
			tbl_Employee original = new tbl_Employee();
			original.Id = 2;
			original.Name = "siva1";
			original.Address = "ongole1";
			original.Description = "siva1";

			var actinres =employeeController.Delete(original);
			//bool real = true;
   		    JsonResult jsonResult = (JsonResult)actinres;
			var ori = (tbl_Employee)jsonResult.Data;
   		    Assert.AreEqual(original, ori);

		}
	}
}
