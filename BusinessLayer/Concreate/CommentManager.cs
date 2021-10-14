using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concreate
{
    public class CommentManager : ICommentService
    {
        ICommentDal _comentDal;

        public CommentManager(ICommentDal comentDal)
        {
            _comentDal = comentDal;
        }

        public void CommentAdd(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void CommentDelete(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void CommentUpdate(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
            return _comentDal.GetListAll(x => x.BlogId == id);
        }
    }
}
