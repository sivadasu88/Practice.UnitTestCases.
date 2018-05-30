using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.UnitTestCases.Data;

namespace UnitTestProject1
{
	[TestClass]
	public class DataReositoryTest

	{
		DataRepository dataRepository = new DataRepository();
		tbl_Employee tblemp = new tbl_Employee();


		[TestMethod]
		public void Delete_DP_Integration()
		{
			bool expected = true;

			bool actual=dataRepository.Delete(3);
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Insert_DP_Integration()
		{
			tblemp.Id = 6;
			tblemp.Name = "sravani3";
			tblemp.Address = "Eluru3";
			tblemp.Description = "sravani3";
			bool expected = true;

			bool actual = dataRepository.Insert(tblemp);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Update_DP_Integration()
		{
			tblemp.Id = 6;
			tblemp.Name = "sravani-3";
			tblemp.Address = "Eluru-3";
			tblemp.Description = "sravani-3";
			bool expected = true;

			bool actual = dataRepository.Update(tblemp);
			Assert.AreEqual(expected, actual);
		}
	}
}
