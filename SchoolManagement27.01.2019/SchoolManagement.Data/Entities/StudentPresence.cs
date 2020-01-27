using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class StudentPresence:BaseEntity
    {
   

        public bool Presence { get; set; }

        public ClassTimeTable ClassTimetable { get; set; }

        public Student Student { get; set; }
    }
}

