using System;
using System.Collections.Generic;

namespace Hexagonal.RESTApiSample.Models
{
    public partial class Company
    {
        public Company()
        {
            Candidate = new HashSet<Candidate>();
        }

        public byte CompanyId { get; set; }
        public string CompanyName { get; set; }

        public ICollection<Candidate> Candidate { get; set; }
    }
}
