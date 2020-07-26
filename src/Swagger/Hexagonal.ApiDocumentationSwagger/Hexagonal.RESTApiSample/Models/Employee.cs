using System;
using System.Collections.Generic;

namespace Hexagonal.RESTApiSample.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public DateTime? HireDate { get; set; }
        public string EmailAddress { get; set; }
        public int? Salary { get; set; }
        public string PersonalWebSite { get; set; }
    }
}
