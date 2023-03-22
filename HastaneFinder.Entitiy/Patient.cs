using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.Entitiy
{
    public class Patient
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Surname { get; set; }
        [StringLength(20)]
        public string BirthDate { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(15)]
        public string Password { get; set; }
        [StringLength(10)]
        public string Telno { get; set; }

        public ICollection<TestResults> TestResults { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
