using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        void AboutAdd(About about);
        void AboutDelete(About about);
        void AboutUpdate(About about);
        List<About> Getlist();
        About GetById(int id);
    }
}
