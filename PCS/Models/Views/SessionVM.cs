using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCS.Models.Views
{
    public class SessionVM
    {
        public Session Session { get; set; }
        public List<Session> SessionList { get; set; }
    }
}