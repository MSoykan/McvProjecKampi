using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace McvProjecKampi.Controllers {
    public class CategoryController : Controller {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        public ActionResult Index() {
            return View();
        }

        public ActionResult GetCategoryList()   {
            var categoryValues = cm.GetList();
            return View(categoryValues);
        }
        [HttpGet]
        public ActionResult AddCategory () {
            return View();      
        }

        [HttpPost]
        public ActionResult AddCategory(Category p) {
            CategoryValidator categoryValidator = new CategoryValidator();
            //cm.(p);
            return RedirectToAction("GetCategoryList");
        }
    }
}