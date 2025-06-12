using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;

namespace DatabaseTask
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string JobTitleForDepartment { get; set; }
        public string HrDepartment { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Hint> Hints { get; set; }
        public ICollection<HRRequest> HRRequests { get; set; }
    }
}

