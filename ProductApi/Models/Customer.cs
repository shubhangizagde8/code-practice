using System;
using System.Collections.Generic;

#nullable disable

namespace ProductApi.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
