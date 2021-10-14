using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogUpdate(Blog blog);
        void BlogDelete(Blog blog);
        List<Blog> GetList();
        List<Blog> GetListWityCategory();
        Blog GetById(int id);
    }
}
