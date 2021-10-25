using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_CORE_ONE_TO_MANY_CRUD.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Please Enter Name")]
        [MaxLength(150,ErrorMessage ="Max Char 150")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Mobile")]
        public string Mobile { get; set; }

        [ForeignKey("Department")]
        public int DepId { get; set; }

        public Department Department { get; set; }
    }
}
