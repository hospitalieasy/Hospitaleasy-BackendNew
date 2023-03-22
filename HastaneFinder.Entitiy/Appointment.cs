using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.Entitiy
{
    public class Appointment
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppId { get; set; }

        [StringLength(20)]
        public string AppDay { get; set; }

        [StringLength(20)]
        public string AppHour { get; set; }

        public bool AppStatus { get; set; }

        // Foreign key property
        public int DoctorId { get; set; }

        // Navigation property
        public virtual Doctor doctors { get; set; }

        public int PatientId { get; set; }
        public virtual Patient patients { get; set; }

      





    }
}
