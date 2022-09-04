using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpManagment.Models
{
    public class Cards
    {
        [Key]
        public Guid CardId { get; set; }

        [ForeignKey("Employees")]
        public int EmployeeRefId { get; set; }
        public Employees EmployeeId { get; set; }

        //public ICollection<Employees> Employees { get; set; }
        //public ICollection<Attendance> Attendance { get; set; }
    }
}
