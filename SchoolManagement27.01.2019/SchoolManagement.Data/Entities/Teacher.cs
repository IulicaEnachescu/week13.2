using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class Teacher:User
    {
        public Teacher()
        {
            Classes = new HashSet<Classe>();
        }
        [Required]
        public int UserId { get; set; }
        
        [Required]
        public bool StatusActive { get; set; }

        public ICollection<Classe> Classes { get; set; }

       // public virtual User User { get; set; }
    }
}
