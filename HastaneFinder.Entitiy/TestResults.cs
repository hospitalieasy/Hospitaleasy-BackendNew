using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.Entitiy
{
    public class TestResults
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestId { get; set; }
       
        public string Feedback { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patients { get; set; }


    }
}
