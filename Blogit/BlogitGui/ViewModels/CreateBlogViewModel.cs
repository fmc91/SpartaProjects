using System;
using System.Collections.Generic;

namespace BlogitGui
{
    public class CreateBlogViewModel
    {
        public string LoggedInUser { get; set; }

        public bool CanSkip { get; set; }
        
        public string Message { get; set; }

        public string UserActualName { get; set; }

        public string BlogName { get; set; }

        public string BlogCategory { get; set; }

        public string BlogAbout { get; set; }
    }
}
