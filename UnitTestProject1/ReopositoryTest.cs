using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.UnitTestCases.Business;
using System.Collections.Generic;

namespace UnitTestProject1
{
	[TestClass]
	public class ReopositoryTest
	{

		GRepository repository = new GRepository();

		[TestMethod]
		public void Delete_Rep_Integration()
		{
			bool expectes = true;
			//Employee employee = new Employee();
			
			
			var orgianl=repository.Delete(3);
			Assert.AreEqual(expectes, orgianl);

		}
		[TestMethod]
		public void GetListById_Rep_Integration()
		{
			List<Employee> expected = new List<Employee>();
			Employee employee = new Employee();
			employee.Id = 3;
			employee.Name = "Sravani1";
			employee.Address = "eluru1";
			employee.Description = "sravani1";
			expected.Add(employee);
			
			var actual=repository.GetListById(3);
			Assert.AreEqual(expected, actual);

		}
		[TestMethod]
		public void GetListById_Rep_count()
		{
			int expected = 2;
			

			List<Employee> original = repository.GetList();

			// assert  
			int actual = original.Count;
			Assert.AreEqual(expected, actual);

		}
		[TestMethod]
		public void GetList_Rep_Integration()
		{
			List<Employee> expected = new List<Employee>();
			Employee employee = new Employee();
			employee.Id = 3;
			employee.Name = "Sravani1";
			employee.Address = "eluru1";
			employee.Description = "sravani1";
			expected.Add(employee);

			var actual = repository.GetListById(3);
			Assert.AreEqual(expected, actual);

		}
	}
}
