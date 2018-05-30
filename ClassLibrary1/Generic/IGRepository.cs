using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.UnitTestCases.Business
{
     public interface IGRepository<T>
    {

		//insert
		bool Insert(T t);

		bool Update(T t);

		bool Delete(int id);

		List<T> GetList();

		Employee GetListById(int id);


    }
}
