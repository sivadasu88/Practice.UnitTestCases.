using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Practice.UnitTestCases.Business;

namespace Practice.UnitTestCases.NUnitTest
{

   
	[TestFixture]
	public class NUnitTestCases
	{
		

		

		[Test]
		public void NUnit_Check_Test()
		{   // 
			//
			//// arrange  

			string expected = "Item 2";
			Logics logics = new Logics();

			// act  
			List<string> original = logics.GetList();

			// assert  
			string actual = original[1];
			Assert.AreEqual(expected, actual);

			
		}
	}
}
