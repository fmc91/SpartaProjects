using System;
using System.Collections.Generic;

namespace BlogitCrud
{
    public class BlogInfo
    {
        public int BlogId { get; set; }

        public string Username { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }

        public string About { get; set; }

        public DateTime ActiveSince { get; set; }

        public DateTime? LatestPost { get; set; }

        public int PostCount { get; set; }
    }
}
