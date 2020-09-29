using System;
using System.Collections.Generic;
using System.Text;

namespace BlogitGui
{
    public class EditPostViewModel
    {
        public string LoggedInUser { get; set; }

        public int PostId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
