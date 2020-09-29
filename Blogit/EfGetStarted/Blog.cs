using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogitEntityModel
{
    public class Blog
    {
        public int BlogId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Category { get; set; }

        public string About { get; set; }

        public List<Post> Posts { get; } = new List<Post>();

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
