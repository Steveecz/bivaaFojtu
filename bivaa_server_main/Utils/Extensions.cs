using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using bivaa_server_main.Models;

namespace bivaa_server_main.Utils
{
    public static class Extensions
    {
        public static string toJson(this object obj) => JsonConvert.SerializeObject(obj);
        
        public static string toJson(this patient patient)
        {
            dynamic result = new JObject();
            result.id = patient.id;
            result.name = patient.name;
            result.diagnose = patient.diagnose;
            result.room = patient.room;


            return Convert.ToString(result);
        }

  

        public static T fromJson<T>(this string obj)
        {
            return JsonConvert.DeserializeObject<T>(obj);
        }

        public static void ApplyJsonContentType(this HttpResponseMessage msg, string mediaType = "application/json")
        {
            msg.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(mediaType);
        }
    }
}