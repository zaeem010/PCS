using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PCS.Models
{
    public class Registration
    {
        [Key]
        public int id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Cnic { get; set; }
        public string Designation { get; set; }
        public string HosName { get; set; }
        public string PreEmail { get; set; }
        public string Email { get; set; }
        public string HospTel { get; set; }
        public string ClinicTel { get; set; }
        public string ResTel { get; set; }
        public string Mobile { get; set; }
        public string Pmdc { get; set; }
        public string Des { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public int Night { get; set; }
        public int Room { get; set; }
        public int fee { get; set; }
        public int Hotel { get; set; }
        public int Total { get; set; }
    }
}