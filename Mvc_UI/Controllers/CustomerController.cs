using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_UI.Controllers
{
    public class CustomerController : Controller
    {
        //ninject

        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        public ActionResult Index()
        {
            var values = customerManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer p)
        {
            customerManager.TInsert(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCustomer(int id)
        {
            var value = customerManager.TGetByID(id);
            customerManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCustomer(int id)
        {
            var value = customerManager.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditCustomer(Customer p)
        {
            customerManager.TUpdate(p);
            return RedirectToAction("Index");
        }
        public ActionResult GetList2()
        {
            var values = customerManager.TGetListByTrabzon();
            return View(values);
        }
    }
}