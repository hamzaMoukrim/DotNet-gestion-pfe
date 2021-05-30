using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pfe.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int EnseignantId { get; set; }
    }
}
