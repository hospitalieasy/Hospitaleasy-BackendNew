using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.Entitiy
{
    public class Doctor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorId { get; set; }
        [StringLength(20)]
        public string DoctorName { get; set; }
        [StringLength(20)]
        public string DoctorSurname { get; set; }
        [StringLength(20)]
        public string Birthdate { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(15)]
        public string Password { get; set; }
        [StringLength(30)]
        public string Rate { get; set; }

        public ICollection<Appointment> Appointments { get; set; }




    }
}
