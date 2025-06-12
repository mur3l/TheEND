using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask
{
    public class Hint
    {
        [Key]
        public int Id { get; set; }
        public string HintType { get; set; }
        public string Involvement { get; set; }
        public string TerminatHireEtc { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}

