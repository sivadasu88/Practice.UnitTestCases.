using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.UnitTestCases.Business.Generics
{
    public interface IGRepository<T>
    {
		bool Insert(T t);

		bool Update(T t);

		bool Delete(int id);

		List<T> GetList();

		T GetListById(int id);
	}
}
