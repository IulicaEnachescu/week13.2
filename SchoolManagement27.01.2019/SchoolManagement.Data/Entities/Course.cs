using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class Course:BaseEntity
    {
        public Course()
        {
            Classes = new HashSet<Classe>();
        }
        [Required]
        public int NumberOfLessons { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        public CategoryTypes Category { get; set; }

        [Required]
        public LanguageTypes Language { get; set; }

        [Required]
        public LevelTypes Level { get; set; }

        public bool StatusActive { get; set; }

        public virtual ICollection<Classe> Classes { get; set; }
    }
    public enum CategoryTypes
    {
        Children, Adults, Teens
    }
    public enum LanguageTypes
    {
        English, French, German
    }
    public enum LevelTypes
    {
        A1Beginer,
        A2Elementary,
        B1Intermediate,
        B2UpperIntermediate,
        B2PreAdvance,
        C1Advance,
        C2Profiency
    }
}

