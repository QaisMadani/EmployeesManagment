using System.ComponentModel.DataAnnotations;

namespace EmpManagment.Models
{
    public class Departments
    {
        [Key]
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? DepartmentLocation { get; set; }
        //public ICollection<Employees> Employees { get; set; }
        //public ICollection<Activities> Activities { get; set; }
    }
}