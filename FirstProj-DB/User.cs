using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    public abstract class User
    {
        string userName { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        string email { get; set; }
        string phone { get; set; }
        string password { get; set; }
        DateTime birthday { get; set; }
        int age { get; set; }
        List<User_Preference> preferences {get; set;}
    }
}
