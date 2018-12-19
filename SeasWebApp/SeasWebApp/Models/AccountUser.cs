using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeasWebApp.Models
{
    public class AccountUser
    {
        public virtual Guid Id { get; set; }
        public virtual IdentityUser Account { get; set; }
        public virtual IList<User> Users { get; set; }
    }
}
