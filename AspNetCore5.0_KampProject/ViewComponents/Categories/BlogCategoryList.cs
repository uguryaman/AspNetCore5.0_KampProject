using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore5._0_KampProject.ViewComponents.Categories
{
    public class BlogCategoryList:ViewComponent
    {
        CategoryManager catMng = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var value = catMng.Getlist();
            return View(value);
        }
    }
}
