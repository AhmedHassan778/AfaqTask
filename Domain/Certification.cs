using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Certification
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /* EF Relations */
        public ICollection<User> Users { get; set; }
    }
}
