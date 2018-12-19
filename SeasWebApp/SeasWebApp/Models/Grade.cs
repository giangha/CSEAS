using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeasWebApp.Models
{
    public class Grade
    {
        public virtual Guid Id { get; set; }
        public virtual string InGrade { get; set; }
    }
}
