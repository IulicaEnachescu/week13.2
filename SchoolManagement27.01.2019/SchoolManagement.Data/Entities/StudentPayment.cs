using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class StudentPayment:BaseEntity
    {
        

        
        public DateTime PaymentDate { get; set; }

        public decimal Ammount { get; set; }

        public Classe Classe { get; set; }

        public Student Student { get; set; }
    }
}
