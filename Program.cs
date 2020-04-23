using HospitalApp;
using System;

namespace Hospital_App
{
    class Program
    {
        public static void Main(string[] args)
        {
            //create instance of patient registration = objects!
            var RegistrationOne = Hospital.RegisterPatient("Rajesh", "Millcreek", "Premera");
          
            //Console.WriteLine($"Age: {RegistrationOne.Age}, MRN:{RegistrationOne.MedicalRecordNumber}, PN: {RegistrationOne.PatientName}, Address: {RegistrationOne.Address}, ID: {RegistrationOne.InsuranceDetails}");

            var isComplete = RegistrationOne.IsComplete();
            //Console.WriteLine($"IsComplete = {isComplete}");

            var RegistrationTwo = Hospital.RegisterPatient("suresh", "Bothell", "Bluecross");
            
            var iscomplete = RegistrationTwo.IsComplete();
            //Console.WriteLine($"Age: {RegistrationTwo.Age}, MRN:{RegistrationTwo.MedicalRecordNumber}, PN: {RegistrationTwo.PatientName}, Address: {RegistrationTwo.Address}");
            //Console.WriteLine($"IsComplete = {iscomplete}");

            var patientRegistrations = Hospital.GetPatientRegistrations();
            foreach (var PatientRegistration in patientRegistrations)

            {
                Console.WriteLine($"Age: {PatientRegistration.Age}, MRN:{PatientRegistration.MedicalRecordNumber}, PN: {PatientRegistration.PatientName}, Address: {PatientRegistration.Address}");
               
            }
            //create instance of appointment = objects!
            var appointmentOne = new Appointment();
            appointmentOne.AppointmentType = TypeofAppointments.Primarycare;
            appointmentOne.ScheduleAppointment(DateTime.Now, "John", "Rajesh");
            //Console.WriteLine($"appointmentOne:: PatientName: {appointmentOne.PatientName}, ProviderName: {appointmentOne.ProviderName}, AppointmentDate: {appointmentOne.AppointmentDate}, AppointmentType: {appointmentOne.AppointmentType}");
            Hospital.ScheduleAppointmnet(DateTime.Now, 1, "Tonny");

            var appointmentTwo = new Appointment();
            appointmentTwo.PatientName = "Rajesh";
            appointmentTwo.AppointmentType = TypeofAppointments.Laboratory;
            appointmentTwo.ModifyAppointment(DateTime.Now.AddDays(20));
            //Console.WriteLine($"appointmentTwo PatientName: {appointmentTwo.PatientName}, AppointmentType: {appointmentTwo.AppointmentType}, AppointmentDate: {appointmentTwo.AppointmentDate},ProviderName: {appointmentTwo.ProviderName}");
            Hospital.ScheduleAppointmnet(DateTime.Now, 2, "John");

            var appointmentThree = new Appointment();
            appointmentThree.PatientName = "RaJaesh";
            appointmentThree.AppointmentType = TypeofAppointments.Specialitycare;
            appointmentThree.CancelAppointment();
            //Console.WriteLine($"appointmentThree PatientName:{appointmentThree.PatientName}, ProviderName: {appointmentThree.ProviderName}, AppointmentType: {appointmentThree.AppointmentType}, AppointmentDate: {appointmentThree.AppointmentDate} ");
           

            //create instance of Patient Report = objects!
            var ReportOne = new PatientReport();
            ReportOne.PateintName = "Rajesh";
            ReportOne.CreateReport("Rajesh", "John", Typeofservices.Primarycare);
            Console.WriteLine($"MRN: {ReportOne.MedicalRecordNumber}, PatientName: {ReportOne.PateintName}, ProviderName: {ReportOne.ProviderName}, ServiceType: {ReportOne.ServiceType}");

            //create instance of billing = objects!
            var BillOne = new Billing();
            BillOne.PatientName = "Rajesh";
            BillOne.ProviderName = "John";
            BillOne.ProcessBilling( "Rajesh", "John", ListofServices.DiagnosticImaging, DateTime.Now);
            Console.WriteLine($"MRN: {BillOne.MedicalRecordNumber}, PatientName: {BillOne.PatientName}, ProviderName: {BillOne.ProviderName}, ServicesList: {BillOne.ServicesList}, CreatedDate: {BillOne.CreatedDate} ");
        

        }
    }
}
