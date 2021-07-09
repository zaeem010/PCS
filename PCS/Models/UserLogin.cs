using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PCS.Models
{
    public class UserLogin
    {
        [Key]
        public int id { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
    }
}