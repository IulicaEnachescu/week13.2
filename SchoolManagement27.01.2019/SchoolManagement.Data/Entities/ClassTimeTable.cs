using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class ClassTimeTable:BaseEntity
    {

        public ClassTimeTable()
        {
            StudentPresences = new HashSet<StudentPresence>();
        }
        public Classe Class { get; set; }

        public int LessonNumber { get; set; }
        public DateTime ClassDate { get; set; }

        public ICollection<StudentPresence> StudentPresences { get; set; }
    }
}
