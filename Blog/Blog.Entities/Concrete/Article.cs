using Blog.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Concrete
{
    public class Article:IEntity
    {
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public string ArticleThumbnailImage { get; set; }
        public string ArticleImage { get; set; }
        public DateTime ArticleCreateDate { get; set; }
        public bool ArticleStatus { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
