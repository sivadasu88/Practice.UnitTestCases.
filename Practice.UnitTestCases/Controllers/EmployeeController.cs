using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.UnitTestCases.Controllers
{
    public class EmployeeController : Controller
    {
		EntityApplicationEntities dbentity = new EntityApplicationEntities();
		// GET: Employee
		public ActionResult Index()
        {
            return View();
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create(tbl_Employee emp)
        {
			bool IsValid = false;
			//if (ModelState.IsValid)
			//{
			//	dbentity.tbl_Employee.Add(emp);
			//	dbentity.SaveChanges();
			//}
			//else
			//{

				var res = dbentity.tbl_Employee.Where(x=>x.Id==emp.Id).FirstOrDefault();
			if (res != null)
			{
				res.Name = emp.Name;
				res.Address = emp.Address;
				res.Description = emp.Description;
			}
			else
			{
				dbentity.tbl_Employee.Add(emp);
			}
				dbentity.SaveChanges();
			//}
			return Json(emp,JsonRequestBehavior.AllowGet);
        }

        // POST: Employee/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(tbl_Employee employee)
        {
			//var res = dbentity.tbl_Employee.Where(tblemp => tblemp.Id == employee.Id).FirstOrDefault();
			
			dbentity.tbl_Employee.Add(employee);
			dbentity.SaveChanges();

			dbentity.tbl_Employee.Attach(employee);
			dbentity.tbl_Employee.Remove(employee);
			dbentity.SaveChanges();
			//bool result = true;

            return Json(employee, JsonRequestBehavior.AllowGet);
        }

		// POST: Employee/Delete/5

		public ActionResult GetList()
		{


		}
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
