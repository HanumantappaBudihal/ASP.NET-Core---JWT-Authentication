using System;
using System.Collections.Generic;

namespace Hexagonal.RESTApiSample.Models
{
    public partial class Candidate
    {
        public byte CandidateId { get; set; }
        public string FullName { get; set; }
        public byte? CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
