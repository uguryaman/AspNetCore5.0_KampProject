using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concreate
{
    public class BlogManager:IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void BlogAdd(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void BlogDelete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public Blog GetById(int id)
        {
           return _blogDal.GetById(id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetListWityCategory()
        {
            return _blogDal.GetListWithCategory();
        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetListAll(x=>x.BlogId==id);

        }
    }
}
