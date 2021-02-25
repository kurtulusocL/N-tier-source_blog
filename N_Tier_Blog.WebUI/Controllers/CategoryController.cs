using N_Tier_Blog.Business.Abstract;
using N_Tier_Blog.Business.Attribute;
using N_Tier_Blog.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace N_Tier_Blog.WebUI.Controllers
{
    [UserLog]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public ActionResult Index()
        {
            return View(_categoryService.GetAll().OrderByDescending(i=>i.CreatedDate).ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category model, HttpPostedFileBase image)
        {
            if (image != null && image.ContentLength > 0)
            {
                image.SaveAs(Server.MapPath("~/img/" + image.FileName));
                model.Photo = image.FileName;
            }
            _categoryService.Insert(model);
            return RedirectToAction(nameof(Create));
        }
        public ActionResult DeActive(int id)
        {
            _categoryService.SetDeActive(id);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Active(int id)
        {
            _categoryService.SetActive(id);
            return RedirectToAction(nameof(Index));
        }
    }
}