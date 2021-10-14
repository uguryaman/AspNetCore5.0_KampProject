using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore5._0_KampProject.ViewComponents.Comments
{
    public class BlogCommentList : ViewComponent
    {
        CommentManager commentmng = new CommentManager(new EfCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            var value = commentmng.GetList(id);
            return View(value);
        }
    }
}
