using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactRepository : GenericRepository<Contact>, IContactDal
    {
    }
}
