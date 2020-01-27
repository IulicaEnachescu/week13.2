using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
 
        public class User : BaseEntity
        {
        public User()
        {
            Admins = new HashSet<Admin>();
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();

        }
        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        [Required]
            [StringLength(50)]
            public string LastName { get; set; }

            [Required]
            [StringLength(50)]
            public string FirstName { get; set; }

            [Required]
            [StringLength(10)]
            public string Password { get; set; }
       
            [Required]
            [StringLength(30)]
            public string Email { get; set; }

            [Required]
            public DateTime DateBirth { get; set; }

            [Required]
            [StringLength(20)]
            public string City { get; set; }

            [Required]
            [StringLength(200)]
            public string Adress { get; set; }

            [Required]
            [StringLength(20)]
            public string Phone { get; set; }

            public ICollection<Admin> Admins { get; set; }

            
            public ICollection<Student> Students { get; set; }

            
            public ICollection<Teacher> Teachers { get; set; }
       
    }
}
