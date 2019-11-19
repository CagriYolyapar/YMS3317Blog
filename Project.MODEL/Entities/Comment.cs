using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Comment : BaseEntity
    {
        public string CommentBody { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public int? ArticleID { get; set; }

        public int? AppUserID { get; set; }



        //Relational Properties

        public virtual Article Article { get; set; }

        public virtual AppUser AppUser { get; set; }


    }
}
