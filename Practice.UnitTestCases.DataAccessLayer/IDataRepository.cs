using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.UnitTestCases.DataAccessLayer
{
	public interface IDataRepository
	{
		bool Insert(tbl_Employee emp);

		bool Update(tbl_Employee employee);

		bool Delete(int id);

		List<tbl_Employee> GetList();

		tbl_Employee GetListById(int id);
	}
}
