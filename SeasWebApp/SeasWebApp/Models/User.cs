using SeasWebApp.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeasWebApp.Models
{
    public class User
    {
        public virtual Guid Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        [DataType(DataType.Date)]
        public virtual DateTime DateOfBirth { get; set; }
        [DataType(DataType.Date)]
        public virtual DateTime CreatedDate { get; set; }
        [DataType(DataType.Date)]
        public virtual DateTime UpdateDate { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
