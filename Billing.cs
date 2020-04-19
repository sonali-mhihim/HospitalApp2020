using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_App
{
    enum ListofServices
    {
        Primarycare,
        Speialitycare,
        Laboratory,
        DiagnosticImaging
    }
    /// <summary>
/// This class represent billing details of the patients
/// </summary>
    class Billing
    {
        private static int lastMedicalRecordNumber = 1;
        #region properties
        public int MedicalRecordNumber{ get; private set; }
        public string PatientName { get; set; }
        public string ProviderName { get; set; }
        public ListofServices ServicesList { get; set; }
        public DateTime CreatedDate { get; private set; }
        #endregion

        #region Constructor
        public Billing()
        {
            MedicalRecordNumber = lastMedicalRecordNumber++;
            CreatedDate = DateTime.Now;
        }

        #endregion

        #region Methods
        /// <summary>
        /// procees billing to get billing details
        /// </summary>
        /// <param name="medicalRecordNumber"> Unique identifier of the patient</param>
        /// <param name="patientName"> Name of the patient</param>
        /// <param name="providerName">Name of the Provider providing service to the patient</param>
        /// <param name="servicesList"> list of  the services recieve by the patient </param>
        /// 
        /// <param name="createdDate"> date and time of the billing</param>
        public void ProcessBilling(string patientName,string providerName, ListofServices servicesList, DateTime createdDate)
        {
            this.PatientName = patientName;
            this.ServicesList = servicesList;
            this.CreatedDate = createdDate;
        }

        #endregion
    }
}
