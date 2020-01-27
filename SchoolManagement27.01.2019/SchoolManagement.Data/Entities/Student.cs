using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class Student:BaseEntity
    {

        public Student()
        {
            this.Classes = new HashSet<Classe>();
            StudentClassEvaluations = new HashSet<StudentClassEvaluation>();
            StudentPayments = new HashSet<StudentPayment>();
            StudentPresences = new HashSet<StudentPresence>();
        }
    
      
        public int UserId { get; set; }

       
        public bool StatusActive { get; set; }

        public int? ContactId { get; set; }


        //public User User { get; set; }

        //public IList<StudentClasse> StudentClasses { get; set; }
        public ICollection<StudentPayment> StudentPayments { get; set; }

        public ICollection<StudentClassEvaluation> StudentClassEvaluations { get; set; }
        public ICollection<StudentPresence> StudentPresences { get; set; }
        public ICollection<Classe> Classes { get; set; }
    }
}
