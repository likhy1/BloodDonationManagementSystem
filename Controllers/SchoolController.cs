using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BloodDonationManagementSystem.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        public SchoolController Get()

        {
            using (var s=new SchoolDBEntities())
            {
                DonarId = s.Id;
                DonarName = s.Name;
            }
           if(Donar.Count==0)
            {          return NotFound();
        }
            return Ok(Donar);
    }

}