using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LaunchpadCodeChallenge.Models.Entitities
{
    public class Department
    {
        [Required]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
