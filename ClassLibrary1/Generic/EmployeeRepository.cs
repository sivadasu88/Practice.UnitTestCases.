//using System;
//using System.Collections.Generic;
//using System.Text;
//using Practice.DataAcessLayer;
//using Practice.UnitTestCases.Data;

//namespace Practice.UnitTestCases.Business
//{
//	public class EmployeeRepository : IGRepository<Employee>
//	{
//		IGDataRepository<tbl_Employee> repo = new TableEmployee();
//		//Insert
//		public bool Delete(int id)
//		{
//		return 	repo.Delete(id);
//		}

//		public List<Employee> GetList()
//		{
//			List<Employee> resList = new List<Employee>();
//		    var list=	repo.GetList();
//			foreach (var item in list)
//			{ Employee emp = new Employee();
//				emp.Id = item.Id;
//				emp.Name = item.Name;
//				emp.Address = item.Address;
//				emp.Description = item.Description;

//				resList.Add(emp);

//			}
//			return resList;
//		}

//		public Employee GetListById(int id)
//		{
//			Employee emp = null;
//			var item = repo.GetListById(id);
//			if (item != null)
//			{
//				emp = new Employee();
//				emp.Id = item.Id;
//				emp.Name = item.Name;
//				emp.Address = item.Address;
//				emp.Description = item.Description;
//			}
//			return emp;
//		}

//		public bool Insert(Employee item)
//		{
//			tbl_Employee emp = new tbl_Employee();
//			emp.Id = item.Id;
//			emp.Name = item.Name;
//			emp.Address = item.Address;
//			emp.Description = item.Description;
//			repo.Insert(emp);
//			return true;
//		}

//		public bool Update(Employee item)
//		{
//			tbl_Employee emp = new tbl_Employee();
//			emp.Id = item.Id;
//			emp.Name = item.Name;
//			emp.Address = item.Address;
//			emp.Description = item.Description;
//			repo.Update(emp);
//			return true;
//		}
//	}
//}
