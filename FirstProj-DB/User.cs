using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    public abstract class User
    {
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public DateTime birthday { get; set; }
        public int age { get; set; }
        public virtual List<User_Preference> preferences {get; set;}
    }  
}
