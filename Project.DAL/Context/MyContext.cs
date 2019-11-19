using Project.MAP.Options;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public  class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new ArticleTagMap());
            modelBuilder.Configurations.Add(new TagMap());
            modelBuilder.Configurations.Add(new CommentMap());
        }


        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<ArticleTag> ArticleTags { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Comment> Comments { get; set; }


    }
}
