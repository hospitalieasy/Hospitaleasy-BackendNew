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
        public int id  { get; set; }
        [StringLength(20)]
        public string name { get; set; }
        [StringLength(20)]
        public string surname { get; set; }
        [StringLength(20)]
        public string birthDate { get; set; }
        [StringLength(30)]
        public string email { get; set; }
        [StringLength(15)]
        public string password { get; set; }
        [StringLength(10)]
        public string telno { get; set; }
        [StringLength(30)]
        public string rate { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

        public ICollection<TestResults> TestResults { get; set; }


    }
}
