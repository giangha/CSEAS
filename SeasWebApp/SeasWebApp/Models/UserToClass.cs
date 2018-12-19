using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeasWebApp.Models
{
    public class UserToClass
    {
        public virtual Guid Id { get; set; }
        public virtual User user { get; set; }
        public virtual Grade grade { get; set; }
    }
}
