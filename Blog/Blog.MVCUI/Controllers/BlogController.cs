using Blog.Business.Abstract;
using Blog.Business.DependancyResolvers.Autofac;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.MVCUI.Controllers
{
    public class BlogController : Controller
    {
        IArticleService _articleService = InstanceFactory.GetInstance<IArticleService>();
        public IActionResult Index()
        {
            var blogList = _articleService.GetAllArticle();
            return View(blogList);
        }

        public IActionResult BlogReadAll(int id)
        {
            var article = _articleService.GetById(id);
            return View(article);
        }
    }
}
