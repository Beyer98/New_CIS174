﻿using Microsoft.AspNetCore.Identity;
using System;

namespace CIS174_Project.Entities
{
    public class UserPerson : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}