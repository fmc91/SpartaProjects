using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlogitEntityModel
{
    public class BlogitContext : DbContext
    {
        public DbSet<User> User { get; set; }
        
        public DbSet<Blog> Blog { get; set; }
        
        public DbSet<Post> Post { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Blogit;");
    }
}
