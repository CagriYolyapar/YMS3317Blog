﻿using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ArticleMap:BaseMap<Article>
    {
        public ArticleMap()
        {
            ToTable("Makaleler");
        }
    }
}
