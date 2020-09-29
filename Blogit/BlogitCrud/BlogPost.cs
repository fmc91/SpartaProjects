using System;
using System.Collections.Generic;
using System.Text;

namespace BlogitCrud
{
    public class BlogPost
    {
        public int PostId { get; set; }

        public string BlogName { get; set; }

        public string Username { get; set; }

        public string Author { get; set; }

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
