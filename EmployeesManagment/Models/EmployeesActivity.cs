using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpManagment.Models
{
    public class EmployeesActivity
    {
        [Key]
        public int EmployeeActivityId { get; set; }

        [ForeignKey("Employees")]
        public int EmployeeRefId { get; set; }
        public Employees EmployeeId { get; set; }

        [ForeignKey("Activities")]
        public int ActivityRefId { get; set; }
        public Activities ActivityId { get; set; }
        public DateTime ActivityDate { get; set; }
    }
}
