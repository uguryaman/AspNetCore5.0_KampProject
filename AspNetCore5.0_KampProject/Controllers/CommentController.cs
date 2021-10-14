using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore5._0_KampProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentmng = new CommentManager(new EfCommentRepository());

        public IActionResult PartialBlogCommentList(int id)
        {
           
            return PartialView();
        }
        public IActionResult PartialNewComment()
        {
            return PartialView();
        }
    }
}
