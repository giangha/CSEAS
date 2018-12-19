using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeasWebApp.Models
{
    public class UserAbsent
    {
        public virtual Guid Id { get; set; }
        public virtual User User { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
