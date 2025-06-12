using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask
{
    public class IntranetId
    {
        [Key]
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public int JobTitleId { get; set; }
        public Employee Employee { get; set; }
    }
}
