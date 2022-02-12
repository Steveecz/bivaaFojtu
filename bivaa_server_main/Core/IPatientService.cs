using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bivaa_server_main.Core
{
    public interface IPatientService
    {
        List<patient> GetAllPatient();
        patient GetPatientById(int id);
        patient CreatePatient(patient patient);
        patient UpdatePatient(int id, patient patient);
        void DeletePatient(int id);
    }
}