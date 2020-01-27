using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Data
{
    public class Classe:BaseEntity
    {
        public Classe()
        {
            this.Students = new HashSet<Student>();
            this.ClassMessages = new HashSet<ClassMessage>();
            this.ClassTimetables = new HashSet<ClassTimeTable>();
            this.StudentPayments = new HashSet<StudentPayment>();
            this.StudentClassEvaluations = new HashSet<StudentClassEvaluation>();
        }
        //public int CourseId { get; set; }

        public int TeacherId { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public Course Course { get; set; }

        public Teacher Teacher { get; set; }

        public ICollection<ClassMessage> ClassMessages { get; set; }

        
        public ICollection <Student> Students { get; set; }

        
        public ICollection<ClassTimeTable> ClassTimetables { get; set; }

        
        public ICollection<StudentPayment> StudentPayments { get; set; }

       
        public virtual ICollection<StudentClassEvaluation> StudentClassEvaluations { get; set; }
    }
}
