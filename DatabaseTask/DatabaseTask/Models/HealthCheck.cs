using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask
{
    public class HealthCheck
    {
        [Key]
        public int Id { get; set; }

        public DateTime Appointment { get; set; }
        public string Replacement { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}
