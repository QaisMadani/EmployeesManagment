using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpManagment.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }

        [ForeignKey("Departments")]
        public int DepartmentRefId { get; set; }
        public Departments DepartmentId { get; set; }

        //[ForeignKey("Cards")]
        public Guid CardRefId { get; set; }
        //public Cards CardId { get; set; }

        //public ICollection<EmployeesActivity> EmployeesActivity { get; set; }
        //public ICollection<Cards> Cards { get; set; }
    }
}
