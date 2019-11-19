using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Tag:BaseEntity
    {
        public string Name { get; set; }

        //Relational Properties


        public virtual List<ArticleTag> ArticleTags { get; set; }

    }
}
