using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpManagment.Models
{
    public class Activities
    {
        [Key]
        public int ActivityId { get; set; }
        public string? ActivityName { get; set; }

        [ForeignKey("Departments")]
        public int DepartmentRefId { get; set; }
        public Departments DepartmentId { get; set; }
        public DateTime ActivityDate { get; set; }
        public string? ActivityLocation { get; set; }

        //public ICollection<EmployeesActivity> EmployeesActivity { get; set; }
    }
}
