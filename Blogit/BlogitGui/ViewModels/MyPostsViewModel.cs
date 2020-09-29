using System;
using System.Collections.Generic;
using BlogitCrud;

namespace BlogitGui
{
    public class MyPostsViewModel
    {
        public string LoggedInUser { get; set; }

        public List<BlogPost> UserPosts { get; set; }
    }
}
