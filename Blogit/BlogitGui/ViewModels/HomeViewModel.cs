using System;
using System.Collections.Generic;
using BlogitCrud;

namespace BlogitGui
{
    public class HomeViewModel
    {
        public string LoggedInUser { get; set; }

        public List<BlogInfo> RecentlyActiveBlogs { get; set; }

        public List<BlogPost> RecentPosts { get; set; }
    }
}
