using Blog.Core.DataAccess;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Abstract
{
    public interface IArticleDal:IEntityRepository<Article>
    {
        List<Article> GetListWithCategory();
        Article GetArticleWithAllRelations(Expression<Func<Article, bool>> filter);
    }
}
