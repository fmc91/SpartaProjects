using System;
using System.Collections.Generic;

namespace BlogitGui
{
    public class BlogStats
    {
        public int BlogId { get; set; }

        public DateTime ActiveSince { get; set; }

        public DateTime? LatestPost { get; set; }

        public int PostCount { get; set; }
    }
}
