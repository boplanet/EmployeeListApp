using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeesListApp.Data
{
    public class Employee
    {
        public string Id { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18, 2)")]
        [Range(typeof(decimal), "0,00", "9999999999999999,99", ErrorMessage = "Plaća može biti do 18 i 2 decimalna mjesta.")]
        public decimal Salary { get; set; }

    }
}
