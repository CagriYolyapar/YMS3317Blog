using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Article:BaseEntity
    {
        public string Title { get; set; }

        public string Context { get; set; }

        public int ViewCount { get; set; }

        public int Likes { get; set; }

        public string ImagePath { get; set; }

        public int? AppUserID { get; set; }

        public int? CategoryID { get; set; }



        //Relational Properties

        public virtual AppUser AppUser { get; set; }

        public virtual List<ArticleTag> ArticleTags { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<Comment> Comments { get; set; }



    }
}
