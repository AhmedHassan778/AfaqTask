using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.ViewModels
{
    public class UserDTO
    {

        public string Name { get; set; }

        public List<String> Certifications { get; set; }
    }
}
