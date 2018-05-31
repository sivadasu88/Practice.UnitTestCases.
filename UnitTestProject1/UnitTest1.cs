using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LogSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.UnitTestCases.Business;

namespace Practice.UnitTestCases.Tests
{
	[TestClass]
	public class UnitTest1
	{
		
		[TestMethod]
		public void Debit_WithValidAmount_Checking()
		{
			// arrange  
			//double beginningBalance = 11.99;
			double debitAmount = 11000;
			double expected = 1000;
			Logics logics = new Logics();



			// act  
			double original=logics.Debit(debitAmount);

			// assert  
			double actual = original;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Debit_WithValidAmount_NegativeChecking()
		{
			// arrange  
			//double beginningBalance = 11.99;
			double debitAmount = 11000;
			double expected = 3000;
			Logics logics = new Logics();



			// act  
			double original = logics.Debit(debitAmount);

			// assert  
			double actual = original;
			Assert.AreNotEqual(expected, actual);
		}
		[TestMethod]
		public void Debit_WithValidAmount_LessChecking()
		{
			// arrange  
			//double beginningBalance = 11.99;
			double debitAmount = 9000;
			double expected = 0;
			Logics logics = new Logics();

			// act  
			double original = logics.Debit(debitAmount);

			// assert  
			double actual = original;
			Assert.AreEqual(expected, actual);
		
		}

		[TestMethod]
		public void Check_List_Count()
		{
			// arrange  
			
			int expected = 4;
			Logics logics = new Logics();

			// act  
			List<string> original = logics.GetList();

			// assert  
			int actual = original.Count;
			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void Check_List_Count_Negative()
		{
			// arrange  

			int expected = 3;
			Logics logics = new Logics();

			// act  
			List<string> original = logics.GetList();

			// assert  
			int actual = original.Count;
			Assert.AreNotEqual(expected, actual);

		}

		[TestMethod]
		public void Check_List_Count_IsExists()
		{
			// arrange  

			string expected = "Item 2";
			Logics logics = new Logics();

			// act  
			List<string> original = logics.GetList();

			// assert  
			string  actual = original[1];
			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void Test_FileExtensions()
		{
			// arrange  
			FileSystemInformation fileinfo = new FileSystemInformation();
			
				  string sourcepath = @"D:\FirstFile\MyTest";
			FileInfo[] fiels = fileinfo.GetFilesFromFolder(sourcepath);
		}

		[TestMethod]
		public void Most_Words()
		{
			// arrange  
			string str = "Test Test New NEw Hello TESt Hello";

			var list = str.Split(' ');

			var result = list
			  .GroupBy(s => s)
			  .Where(g => g.Count() > 1)
			  .OrderByDescending(g => g.Count())
			  // .Select(g => g.Count());
			  .Select(x => new  { Name = x.Key, Count = x.Count() }).FirstOrDefault();
		}
		
		
	}
}
