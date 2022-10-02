using System;
using System.Collections.Generic;

namespace Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /* EF Relations */
        public ICollection<Certification> Certifications { get; set; }


    }
}
