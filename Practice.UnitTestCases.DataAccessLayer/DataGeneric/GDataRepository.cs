using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice.UnitTestCases.DataAccessLayer
{
	public class GDataRepository : IGDataRepository<tbl_Employee>
	{
		EntityApplicationEntities dbentity = new EntityApplicationEntities();

	
	    public bool Delete(int id)
		{
			
			var res = dbentity.tbl_Employee.Where(tblemp => tblemp.Id == id).FirstOrDefault();			
			dbentity.tbl_Employee.Attach(res);
			dbentity.tbl_Employee.Remove(res);
			dbentity.SaveChanges();
			return true;
		}

		public List<tbl_Employee> GetList()
		{
			return dbentity.tbl_Employee.ToList();


		}

		public tbl_Employee GetListById(int id)
		{
			return dbentity.tbl_Employee.Where(x => x.Id ==id).FirstOrDefault();
			
		}

		public bool Insert(tbl_Employee emp)
		{
			dbentity.tbl_Employee.Add(emp);
			dbentity.SaveChanges();
			return true;
		}

		public bool Update(tbl_Employee employee)
		{

			var res = dbentity.tbl_Employee.Where(x => x.Id == employee.Id).FirstOrDefault();

			res.Name = employee.Name;
			res.Address = employee.Address;
			res.Description = employee.Description;
			dbentity.SaveChanges();
			return true;
		}
	}
}
