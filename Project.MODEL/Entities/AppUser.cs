﻿using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public UserRole? Role { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public AppUser()
        {
            Role = UserRole.Member;
        }

        //Relational Properties

        public virtual List<Article> Articles { get; set; }

        public virtual List<Comment> Comments { get; set; }


    }
}