using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PCS.Models
{
    public class Session
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}