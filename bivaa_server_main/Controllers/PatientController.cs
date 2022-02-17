using bivaa_server_main.Core;
using bivaa_server_main.Utils;
using bivaa_server_main.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace bivaa_server_main.Controllers
{
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    public class PatientController : BaseController
    {
        private IPatientService PatientService;
        public PatientController(ICommonService commonService, IPatientService PatientService) : base(commonService)
        {
            this.PatientService = PatientService;
        }

        [HttpGet]
        [ActionName("all")]
        public HttpResponseMessage GetAll()
        {
            var patient = PatientService.GetAllPatient();
            return commonService.GetResponse(patient.toJson());
        }

        [HttpGet]
        [ActionName("detail")]
        public HttpResponseMessage GetDetail(int id)
        {
            var patient = PatientService.GetPatientById(id);
            return commonService.GetResponse(patient.toJson());
        }

        [HttpPost]
        [ActionName("create")]
        public HttpResponseMessage Create(HttpRequestMessage req)
        {
            // request handling and deserialization
            var requestBody = req.Content.ReadAsStringAsync().Result;
            var requestPatient = requestBody.fromJson<patient>();

            // create obj in database - service call
            var createdPatient = PatientService.CreatePatient(requestPatient);

            // return created object
            return commonService.GetResponse(createdPatient.toJson());
        }

        [HttpPut]
        [ActionName("update")]
        public HttpResponseMessage Update(int id, HttpRequestMessage req)
        {
            // request handling and deserialization
            var requestBody = req.Content.ReadAsStringAsync().Result;
            var requestPatient = requestBody.fromJson<patient>();

            // create obj in database - service call
            var updatedPatient = PatientService.UpdatePatient(id, requestPatient);

            // return created object
            return commonService.GetResponse(updatedPatient.toJson());
        }

        [HttpDelete]
        [ActionName("delete")]
        public HttpResponseMessage Delete(int id)
        {
            PatientService.DeletePatient(id);
            return commonService.GetResponse();
        }
    }
}