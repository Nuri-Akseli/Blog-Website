using Blog.Core.DataAccess.EntityFramework;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal : EfEntityRepositoryBase<Article, BlogContext>, IArticleDal
    {
        public List<Article> GetListWithCategory()
        {
            using (var context=new BlogContext())
            {
                return context.Articles.Include(table => table.Category).ToList();
            }
        }
    }
}
