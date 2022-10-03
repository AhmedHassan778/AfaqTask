using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Domain
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        /* EF Relations */
        public ICollection<Certification> Certifications { get; set; }

    }
}
