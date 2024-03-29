﻿using System.ComponentModel.DataAnnotations;

namespace PrivateTuition.Web.Models
{
    public class UserModel
    {
        public string UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public IEnumerable<string> SelectedRoles { get; set; }
    }
}
