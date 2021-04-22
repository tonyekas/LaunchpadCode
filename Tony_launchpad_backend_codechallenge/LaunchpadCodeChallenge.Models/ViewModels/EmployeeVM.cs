using LaunchpadCodeChallenge.Models.Entitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchpadCodeChallenge.Models.ViewModels
{
    public class EmployeeVM
    {
        public EmployeeVM(Employee src)
        {
            Id = src.Id;
            FirstName = src.FirstName;
            LastName = src.LastName;
            Address = src.Address;
            JobTitle = src.JobTitle;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public object Address { get; set; }
        public string JobTitle { get; set; }
    }
}
