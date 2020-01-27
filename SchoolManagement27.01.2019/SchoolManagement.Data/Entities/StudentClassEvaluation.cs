using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class StudentClassEvaluation:BaseEntity
    {
        public Classe Class { get; set; }

        public Student Student { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public int Grade { get; set; }
        public DateTime Date { get; set; }

       
    }
}
