using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.UnitTestCases.Business.Generics
{
	class GenericRepository : IGRepository<Employee>
	{
		public bool Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<Employee> GetList()
		{
			throw new NotImplementedException();
		}

		public Employee GetListById(int id)
		{
			throw new NotImplementedException();
		}

		public bool Insert(Employee t)
		{
			throw new NotImplementedException();
		}

		public bool Update(Employee t)
		{
			throw new NotImplementedException();
		}
	}
}
