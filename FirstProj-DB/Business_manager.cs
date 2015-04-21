using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    public class Business_manager: User
    {
        List<Business> ownedBusinesses { get; set; }
    }
}
