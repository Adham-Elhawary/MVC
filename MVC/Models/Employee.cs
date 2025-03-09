namespace MVC.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string? Email { get; set; }

        public int salary { get; set; }

        public int? DepartmentId { get; set; }

        public Department? Department { get; set; }

    }
}
