using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.UnitTestCases.Data
{
     public interface IDataRepository
    {

		//insert
		bool Insert(tbl_Employee emp);

		bool Update(tbl_Employee employee);

		bool Delete(int id);

		List<tbl_Employee> GetList();

		tbl_Employee GetListById(int id);


    }
}
