using HospitalApp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Hospital_App
{
    static class Hospital
    {
        private static HospitalContext db = new HospitalContext();


        /// <summary>
        /// register patient at the Hospital
        /// </summary>
        /// <param name="patientName"> name of the Patient</param>
        /// <param name="Address"> address of the patient</param>
        /// <param name="insuranceDetails"> Insurance deatails of the patient</param>
        /// <returns></returns>
        public static PatientRegistration RegisterPatient(string patientName, string Address, string insuranceDetails)
        {
            var patientRegistration = new PatientRegistration
            {
                PatientName = patientName,
                Address = Address,
                InsuranceDetails = insuranceDetails
            };
            db.patientRegistrations.Add(patientRegistration);
            db.SaveChanges();
            return patientRegistration;
        }

        public static IEnumerable<PatientRegistration> GetPatientRegistrations()
        {
            return db.patientRegistrations;
        }

        public static bool IsComplete(int MedicalRecordNumber)
        {
            bool complete = true;
            return complete;
        }

        public static void ScheduleAppointmnet(DateTime AppointmnetDate, int MedicalRecordNumber, string providerName)
        {
            //Locate the patientRegistration
            //LINQ
            var PatientRegistration = db.patientRegistrations.SingleOrDefault(PatientRegistration => PatientRegistration.MedicalRecordNumber == MedicalRecordNumber);

            //Schedule appointment of the patient
            if (PatientRegistration != null)
            {
                //add a Appointment
                var appointment = new Appointment
                {
                    AppointmentType = TypeofAppointments.Primarycare

                };
                appointment.ScheduleAppointment(AppointmnetDate, providerName, PatientRegistration.PatientName);
                db.Appointments.Add(appointment);
                db.SaveChanges();

                Console.WriteLine("Appointment Successfully scheduled!");
            }
            else
            {
                Console.WriteLine($"patient with MedicalRecordNumber= {MedicalRecordNumber} not found");
            }
        }
    }
}
