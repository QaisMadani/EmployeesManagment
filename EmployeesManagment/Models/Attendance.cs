using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpManagment.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }

        [ForeignKey("Cards")]
        public Guid CardRefId { get; set; }
        public Cards CardId { get; set; }
        public bool Checkin { get; set; }
        public DateTime AttendanceDate { get; set; }
    }
}
