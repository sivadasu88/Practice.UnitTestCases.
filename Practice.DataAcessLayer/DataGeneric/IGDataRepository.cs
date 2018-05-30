using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.UnitTestCases.Data
{
     public interface IGDataRepository<T>
    {

		//insert
		bool Insert(T t);

		bool Update(T t);

		bool Delete(int id);

		List<T> GetList();

		T GetListById(int id);


    }
}
