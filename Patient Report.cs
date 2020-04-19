using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace Hospital_App
{
   enum Typeofservices
    {
        Primarycare,
        Specialitycare,
        Laboratory,
        DiagnosticImaging
    }
    /// <summary>
    /// This class represent summary of patients' visit
    /// </summary>
    class PatientReport
    {
        private static int lastMedicalRecordNumber = 1;
        #region properties
        public int MedicalRecordNumber { get; private set; }
        public string PateintName { get; set; }
        public string ProviderName { get; private set; }
        public Typeofservices ServiceType { get; private set; }
        #endregion

        #region constructor

        public PatientReport()
        {
            MedicalRecordNumber = lastMedicalRecordNumber++;
        }

        #endregion

        #region Methods
        /// <summary>
        /// create report to share with patients and process billing
        /// </summary>
        /// <param name="patientName"> name of the patient</param>
        /// <param name="providerName"> name of provider</param>
        /// <param name="serviceType">type of medical services</param>
        public void CreateReport(string patientName, string providerName, Typeofservices serviceType)
        {
            this.PateintName = patientName;
            this.ProviderName = providerName;
            this.ServiceType = serviceType;
        }

        #endregion
    }
}
