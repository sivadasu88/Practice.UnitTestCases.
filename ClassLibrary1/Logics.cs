using System;
using System.Collections.Generic;

namespace Practice.UnitTestCases.Business.Test
{
    public class Logics
    {


		public double Debit(double amount)
		{
			double res = 0;
			if (amount > 10000)
			{
				res= 1000;

			}
			else if (amount < 10000)
			{
				res= 0;
			}
			return res;
		}

		public List<string> GetList()
		{
			List<string> res = new List<string>();
			res.Add("Item 1");

			res.Add("Item 2");
			res.Add("Item 3");
			res.Add("Item 4");

			return res;
		}
	}
}
