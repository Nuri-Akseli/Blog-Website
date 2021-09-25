using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Concrete
{
    public class ArticleManager:IArticleService
    {
        private IArticleDal _articleDal;
        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public List<Article> GetAllArticle()
        {
            return _articleDal.GetListWithCategory();
        }

        public Article GetById(int id)
        {
            return _articleDal.Get(article => article.ArticleId == id);
        }
    }
}
