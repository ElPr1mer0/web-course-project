﻿using System.Collections.Generic;

namespace WebCourseProject.Domain.Entities
{
    public class Users
    {
        public int userId { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int roleId { get; set; }
        public Roles? Role { get; set; }
        public ICollection<Permissions>? Permissions { get; set; }

    }
}
