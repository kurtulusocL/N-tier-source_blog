using N_Tier_Blog.Business.Abstract;
using N_Tier_Blog.Models.EntityModels;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace N_Tier_Blog.WebUI.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public ActionResult Index(int page = 1)
        {
            return View(_articleService.GetAll().Where(i => i.IsConfirmed == true).OrderByDescending(i => i.CreatedDate).ToPagedList(page, 25));
        }
        public ActionResult _HitRead(int? id)
        {
            return PartialView(_articleService.HitRead(id));
        }
        public ActionResult Like(int id, Article model)
        {
            _articleService.Like(id);
            return new RedirectToRouteResult(new RouteValueDictionary(new { action = "Detail", controller = "Company", id = model.Id }));
        }
    }
}