using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Data
{
    public class LeaveAllocation
    {
        public int DaysTaken { get; set; }
        [ForeignKey("LeavetypeId")]
        public Leavetype leavetype { get; set; }
        public int LeavetypeId { get; set; }
        public int EmplyeeId { get; set; }
    }

}
