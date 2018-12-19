using SeasWebApp.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeasWebApp.Models
{
    public class UserGrade
    {
        public virtual Guid Id { get; set; }
        public User User { get; set; }
        public virtual GradePointType GradeType { get; set; }
        public virtual int point { get; set; }
        [DataType(DataType.Date)]
        public virtual DateTime Date { get; set; }
    }
}
