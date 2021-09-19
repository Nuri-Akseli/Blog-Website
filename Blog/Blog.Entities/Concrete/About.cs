using Blog.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Concrete
{
    public class About :IEntity
    {
        public int AboutId { get; set; }
        public string AboutFirstDetails { get; set; }
        public string AboutSecondDetails { get; set; }
        public string AboutFirstImage { get; set; }
        public string AboutSecondImage { get; set; }
        public string AboutMapLocation { get; set; }
        public bool AboutStatus { get; set; }
    }
}
