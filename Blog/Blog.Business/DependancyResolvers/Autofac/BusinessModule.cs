using Autofac;
using Blog.Business.Abstract;
using Blog.Business.Concrete;
using Blog.DataAccess.Abstract;
using Blog.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.DependancyResolvers.Autofac
{
    public class BusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AboutManager>().As<IAboutService>().SingleInstance();
            builder.RegisterType<ArticleManager>().As<IArticleService>().SingleInstance();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<CommentManager>().As<ICommentService>().SingleInstance();
            builder.RegisterType<ContactManager>().As<IContactDal>().SingleInstance();
            builder.RegisterType<WriterManager>().As<IWriterService>().SingleInstance();

            builder.RegisterType<EfAboutDal>().As<IAboutDal>();
            builder.RegisterType<EfArticleDal>().As<IArticleDal>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
            builder.RegisterType<EfCommentDal>().As<ICommentDal>();
            builder.RegisterType<EfContactDal>().As<IContactDal>();
            builder.RegisterType<EfWriterDal>().As<IWriterDal>();


            builder.RegisterType<BlogContext>().As<DbContext>();
        }
        
    }
}
