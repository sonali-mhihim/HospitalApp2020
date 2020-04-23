using Hospital_App;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalApp
{
    class HospitalContext : DbContext
    {
        public DbSet<PatientRegistration> patientRegistrations  { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalApr20;Integrated Security=True;Connect Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientRegistration>(entity =>
            {
                entity.ToTable("PatientRegistrations");
                entity.HasKey(PR => PR.MedicalRecordNumber);
                entity.Property(PR => PR.MedicalRecordNumber)
                .ValueGeneratedOnAdd();
                entity.Property(PR => PR.PatientName)
                .IsRequired();
                entity.Property(PR => PR.Address)
                .IsRequired()
                .HasMaxLength(150);
                entity.Property(PR => PR.InsuranceDetails)
                .IsRequired()
                .HasMaxLength(200);
            } 
                
                );
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("appointmnets");
                entity.HasKey(a => a.AppointmentId);
                entity.Property(a => a.AppointmentId)
                .ValueGeneratedOnAdd();
                entity.Property(a => a.PatientName)
                .IsRequired()
                .HasMaxLength(100);
                entity.Property(a => a.ProviderName)
                .IsRequired();
                entity.Property(a => a.AppointmentType)
                .IsRequired();
                entity.Property(a => a.AppointmentDate)
                .ValueGeneratedOnAdd();
            }
                );
        }
    }
}
