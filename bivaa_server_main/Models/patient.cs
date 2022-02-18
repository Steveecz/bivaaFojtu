namespace bivaa_server_main.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using Newtonsoft.Json;
    
  
    using System.Data.Entity;
    using System.Linq;


    [Table("patient")]
    public partial class patient
    {
        //public virtual DbSet<patient> patient { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(45)]
        public string name { get; set; }

        [StringLength(45)]
        public string diagnose { get; set; }

        public int? room { get; set; }
    }
}
