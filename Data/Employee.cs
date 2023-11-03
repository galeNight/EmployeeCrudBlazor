using System.ComponentModel.DataAnnotations;

namespace EmployeeCrudBlazor.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string city { get; set; }
        public string Designation { get; set; }
    }
}
