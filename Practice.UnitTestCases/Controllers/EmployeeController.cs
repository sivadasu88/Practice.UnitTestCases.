using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LogSystem;
using Practice.UnitTestCases.Business;

namespace Practice.UnitTestCases.Controllers
{
    public class EmployeeController : Controller
    {
		IRepository repository = new Repository();
		LogFile log = new LogFile();
		// GET: Employee
		public ActionResult Index()
        {
            return View();
        }

       
        // GET: Employee/Create
		
        public ActionResult Create(Employee emp)
        {
			bool res = false;
			try
			{
				var employee = repository.GetListById(emp.Id);
				if (employee != null)
				{
					res = repository.Update(emp);
					log.WriteMessage("updated sucessfully");
				}
				else
				{
					res = repository.Insert(emp);
					log.WriteMessage("Inserted Sussfully");
				}
			}
			catch (Exception ex)
			{
				log.WriteExceptionMessage(ex.Message);

			}
			return Json(res,JsonRequestBehavior.AllowGet);
        }
       

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
			bool res = false;
			res = repository.Delete(id);

            return Json(res, JsonRequestBehavior.AllowGet);
        }

		// POST: Employee/Delete/5

		public ActionResult GetList()
		{
			List<Employee> list = new List<Employee>();
			list=repository.GetList();
			return Json(list,JsonRequestBehavior.AllowGet);
		}
       
    }
}
