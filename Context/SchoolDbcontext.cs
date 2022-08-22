using BloodDonationManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodDonationManagementSystem.Context
{
    public class SchoolDbcontext : Dbcontext
    {
        public SchoolDbcontext(DbcontextOptions<SchoolDbcontext> options:base (options))
            {
        }
            public Dbset <School> school { get; set; }
    }
        }
    
