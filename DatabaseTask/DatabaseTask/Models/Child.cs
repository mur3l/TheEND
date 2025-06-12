using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask
{
    public class Child
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Age { get; set; }
        public string ChristmasGift { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
