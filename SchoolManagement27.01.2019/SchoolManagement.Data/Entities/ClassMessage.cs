using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class ClassMessage: BaseEntity
    {

       // public int ClassId { get; set; }


        public DateTime Date { get; set; }

        [Required]
        [StringLength(500)]
        public string Message { get; set; }
        public Classe Class  { get; set; }

}
}

