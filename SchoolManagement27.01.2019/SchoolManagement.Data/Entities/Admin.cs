using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class Admin:User
    {
      //  public int UserId { get; set; }

        [Required]
        [StringLength(20)]
        public string Role { get; set; }

        public User User { get; set; }
    }
}
