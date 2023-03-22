using HastaneFinder.Entitiy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.DataAcess
{
    public class HastaneDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=tcp:hospitaleasydb.database.windows.net,1433;Initial Catalog=hospitaleasyDB;Persist Security Info=False;User ID=hospitaleasy;Password=Yasar2132;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        }

        public DbSet<Hastaneler> hastaneler { get; set; }

        public DbSet<Doctor> Tbl_Doctor { get; set; }


        public DbSet<Patient> Patients { get; set; }

        public DbSet<TestResults> TestResults { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Contact> Contacts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .HasMany(c => c.Appointments)
                .WithOne(o => o.patients)
                .HasForeignKey(o => o.PatientId);

            modelBuilder.Entity<Doctor>()
               .HasMany(c => c.Appointments)
               .WithOne(o => o.doctors)
               .HasForeignKey(o => o.DoctorId);

            modelBuilder.Entity<Patient>()
             .HasMany(c => c.TestResults)
             .WithOne(o => o.Patients)
             .HasForeignKey(o => o.PatientId);

           
        }

    }
}
