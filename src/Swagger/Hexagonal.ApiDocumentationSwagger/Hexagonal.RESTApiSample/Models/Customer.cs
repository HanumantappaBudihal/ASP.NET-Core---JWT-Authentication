using System;
using System.Collections.Generic;

namespace Hexagonal.RESTApiSample.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
    }
}
