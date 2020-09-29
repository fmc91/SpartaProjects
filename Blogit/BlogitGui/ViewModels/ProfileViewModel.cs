using BlogitCrud;
using System;
using System.Collections.Generic;

namespace BlogitGui
{
    public class ProfileViewModel
    {
        public string LoggedInUser { get; set; }

        public string EmailAddress { get; set; }

        public string Name { get; set; }

        public string BlogName { get; set; }

        public string BlogCategory { get; set; }

        public string BlogAbout { get; set; }

        public BlogStats BlogStats { get; set; }
    }
}
