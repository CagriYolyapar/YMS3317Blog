﻿using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public  class ArticleTagMap:BaseMap<ArticleTag>
    {
        public ArticleTagMap()
        {
            ToTable("Makale Etiketleri");
            Ignore(x => x.ID);
            HasKey(x => new { x.ArticleID, x.TagID });
        }
    }
}
