using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore5._0_KampProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var value = bm.GetListWityCategory();
            return View(value);
        }
        public IActionResult BlogDetails(int id)
        {
            var value = bm.GetBlogById(id);
            return View(value);
        }
    }
}
