using BlogitCrud;
using System;
using System.Collections.Generic;

namespace BlogitGui
{
    public class ViewBlogViewModel
    {
        public string LoggedInUser { get; set; }

        public BlogInfo BlogInfo { get; set; }

        public List<BlogPost> Posts { get; set; }
    }
}
