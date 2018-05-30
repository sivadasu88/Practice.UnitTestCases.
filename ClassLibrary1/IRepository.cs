using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.UnitTestCases.Business
{
     public interface IRepository
    {

		//insert
		bool Insert(Employee emp);

		bool Update(Employee employee);

		bool Delete(int id);

		List<Employee> GetList();

		Employee GetListById(int id);


    }
}
