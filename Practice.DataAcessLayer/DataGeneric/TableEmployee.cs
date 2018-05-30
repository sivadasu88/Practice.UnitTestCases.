using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Practice.UnitTestCases.Data
{
public	class TableEmployee : IGDataRepository<tbl_Employee>
	{
		EntityApplicationEntities dbentity = new EntityApplicationEntities();


		//Insert
		public bool Delete(int id)
		{
			var employee = dbentity.tbl_Employee.Where(tblemp => tblemp.Id == id).FirstOrDefault();
			dbentity.tbl_Employee.Attach(employee);
			dbentity.tbl_Employee.Remove(employee);
			dbentity.SaveChanges();
			return true;
		}

			public List<tbl_Employee> GetList()
		{
			
		return	dbentity.tbl_Employee.ToList();
		}

		public tbl_Employee GetListById(int id)
		{
			var result = dbentity.tbl_Employee.Where(tbemp => tbemp.Id == id).FirstOrDefault();
			return result;
		}

		public bool Insert(tbl_Employee emp)
		{

			dbentity.tbl_Employee.Add(emp);
			dbentity.SaveChanges();
			return true;
		}

		public bool Update(tbl_Employee employee)
		{
			//var emp = dbentity.tbl_Employee.FirstOrDefault<tbl_Employee>();
			////emp.Id = employee.Id;
			//emp.Description = employee.Description;
			//emp.Address = emp.Address;

			//dbentity.tbl_Employee.Add(emp);
			
				var result = dbentity.tbl_Employee.SingleOrDefault(b => b.Id == employee.Id);
				if (result != null)
				{
					result.Description=employee.Description;
				result.Name = employee.Name;
				result.Address = employee.Address;
				dbentity.SaveChanges();
				}
			
			
			return true;
		}
	}
}
