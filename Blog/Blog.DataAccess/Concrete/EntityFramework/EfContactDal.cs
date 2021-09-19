using Blog.Core.DataAccess.EntityFramework;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Concrete.EntityFramework
{
    public class EfContactDal:EfEntityRepositoryBase<Contact,BlogContext>,IContactDal
    {
    }
}
