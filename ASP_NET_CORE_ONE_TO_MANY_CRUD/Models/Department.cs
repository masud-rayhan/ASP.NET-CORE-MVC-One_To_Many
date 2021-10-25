using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_CORE_ONE_TO_MANY_CRUD.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string DepName { get; set; }

        public string DepChairman { get; set; }

        public virtual ICollection<Student> students { get; set; }
    }
}
