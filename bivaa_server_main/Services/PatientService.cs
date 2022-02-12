using bivaa_server_main.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bivaa_server_main.Services
{
    public class PatientService : IPatientService
    {
        public List<patient> GetAllPatient()
        {
            using (var db = new AppDbContext())
            {
                var patients = (from tx in db.patient select tx).ToList();
                return patients;
            }
        }
       

        public patient GetPatientById(int id)
        {
            using (var db = new AppDbContext())
            {
                var patient = (from tx in db.tax_rate where tx.id == id select tx).SingleOrDefault();
                return patient;
            }
        }
        public patient CreatePatient(patient patient)
        {
            using (var db = new AppDbContext())
            {
                db.tax_rate.Add(patient);
                db.SaveChanges();
                return patient;
            }
        }

        public void DeletePatient(int id)
        {
            using (var db = new AppDbContext())
            {
                var patient = new patient { id = id };
                db.patient.Attach(patient);
                db.patient.Remove(patient);
                db.SaveChanges();
            }
        }

        public patient UpdatePatient(int id, patient requestpatient)
            {
            var patient = GetPatientById(id);
            if (patient != null)
            {
                using (var db = new AppDbContext())
                {
                    patient.name = requestpatient.name;
                    patient.diagnose = requestpatient.diagnose;
                    patient.room = requestpatient.room;
                    db.SaveChanges();
                }
                return patient;
            }
            else
            {
                // log error
                return null;
            }
        }
    }
}