using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        void CommentUpdate(Comment comment);
        void CommentDelete(Comment comment);
        List<Comment> GetList(int id);
        Comment GetById(int id);

    }
}
