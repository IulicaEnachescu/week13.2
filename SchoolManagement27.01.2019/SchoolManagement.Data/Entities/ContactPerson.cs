using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class ContactPerson:IdentityUser
    {
        public ContactPerson()
        {
            Students = new HashSet<Student>();
        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Adress { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }
        


        public virtual ICollection<Student> Students { get; set; }
    }
}

