using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.UnitTestCases.DataAccessLayer
{
	public interface IGDataRepository<T>
	{
		bool Insert(T t);

		bool Update(T t);

		bool Delete(int id);

		List<T> GetList();

		T GetListById(int id);
	}
}
