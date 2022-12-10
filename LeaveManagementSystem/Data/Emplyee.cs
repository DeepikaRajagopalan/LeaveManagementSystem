using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace LeaveManagementSystem.Data
{
    public class Emplyee: IdentityUser
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateofBirth { get; set; }

        public DateTime DateofJoining { get; set; }
    }
}
