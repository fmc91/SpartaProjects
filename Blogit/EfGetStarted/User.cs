using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlogitEntityModel
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public DateTime JoinDate { get; set; }

        public string Name { get; set; }

        public Blog Blog { get; set; }
    }
}
