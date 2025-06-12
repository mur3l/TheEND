using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Department { get; set; }
        public string IntranetId { get; set; }
        public string Child { get; set; }
        public string LoanableItem { get; set; }
        public string Vacation { get; set; }
        public string Hint { get; set; }
        public string SickLeave { get; set; }
        public string HRRequest { get; set; }
        public string HealthCheck { get; set; }

