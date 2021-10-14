using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        void ContactAdd(Contact contact);
        void ContactUpdate(Contact contact);
        void ContactDelete(Contact contact);
        List<Contact> GelList();
        Contact GetById(int id);

    }
}
