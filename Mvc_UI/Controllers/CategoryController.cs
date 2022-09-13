using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_UI.Controllers
{
    public class CategoryController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Categories.ToList();
            return View(values);
        }
    }
}