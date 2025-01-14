﻿using Microsoft.AspNetCore.Identity;

namespace App.Identity.Domain
{
    public class Users : IdentityUser
    {
        public string NomeCompleto { get; set; }

        public string Member { get; set; } = "Member";

        public string OrgId { get; set; }

        public Organization Organization { get; set; }


    }

    public class Organization
    {
        public string Id { get; set; }
        public string Name { get; set; } 
    }
}
