using HospitalApp;
using System;

namespace Hospital_App
{
    class Program
    {
        public static void Main(string[] args)
        {
            //create instance of patient registration = objects!
            var RegistrationOne = new PatientRegistration();
            RegistrationOne.Age = 20;
            RegistrationOne.PatientName = "Rajesh";
            RegistrationOne.Address = "Mill Creek";
            RegistrationOne.InsuranceDetails = "Premera";
            Console.WriteLine($"Age: {RegistrationOne.Age}, MRN:{RegistrationOne.MedicalRecordNumber}, PN: {RegistrationOne.PatientName}, Address: {RegistrationOne.Address}, ID: {RegistrationOne.InsuranceDetails}");

            var isComplete = RegistrationOne.IsComplete();
            Console.WriteLine($"IsComplete = {isComplete}");

            var RegistrationTwo = new PatientRegistration();
            RegistrationTwo.Age = 56;
            RegistrationTwo.PatientName = "Suresh";
            RegistrationTwo.Address = "Bothell";
            var iscomplete = RegistrationTwo.IsComplete();
            Console.WriteLine($"Age: {RegistrationTwo.Age}, MRN:{RegistrationTwo.MedicalRecordNumber}, PN: {RegistrationTwo.PatientName}, Address: {RegistrationTwo.Address}");
            Console.WriteLine($"IsComplete = {iscomplete}");

            //create instance of appointment = objects!
            var appointmentOne = new Appointment();
            appointmentOne.AppointmentType = TypeofAppointments.Primarycare;
            appointmentOne.ScheduleAppointment(DateTime.Now, "John", "Rajesh");
            Console.WriteLine($"appointmentOne:: PatientName: {appointmentOne.PatientName}, ProviderName: {appointmentOne.ProviderName}, AppointmentDate: {appointmentOne.AppointmentDate}, AppointmentType: {appointmentOne.AppointmentType}");


            var appointmentTwo = new Appointment();
            appointmentTwo.PatientName = "Rajesh";
            appointmentTwo.AppointmentType = TypeofAppointments.Laboratory;
            appointmentTwo.ModifyAppointment(DateTime.Now.AddDays(20));
            Console.WriteLine($"appointmentTwo PatientName: {appointmentTwo.PatientName}, AppointmentType: {appointmentTwo.AppointmentType}, AppointmentDate: {appointmentTwo.AppointmentDate},ProviderName: {appointmentTwo.ProviderName}");


            var appointmentThree = new Appointment();
            appointmentThree.PatientName = "RaJaesh";
            appointmentThree.AppointmentType = TypeofAppointments.Specialitycare;
            appointmentThree.CancelAppointment();
            Console.WriteLine($"appointmentThree PatientName:{appointmentThree.PatientName}, ProviderName: {appointmentThree.ProviderName}, AppointmentType: {appointmentThree.AppointmentType}, AppointmentDate: {appointmentThree.AppointmentDate} ");


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
