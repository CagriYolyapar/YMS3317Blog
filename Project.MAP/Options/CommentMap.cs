﻿using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class CommentMap:BaseMap<Comment>
    {
        public CommentMap()
        {
            ToTable("Yorumlar");
            Property(x => x.CommentBody).HasColumnName("Yorum Icerigi");
        }
    }
}
