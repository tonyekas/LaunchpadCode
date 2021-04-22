using LaunchpadCodeChallenge.Models.Entitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchpadCodeChallenge.Models.ViewModels
{
    public class DepartmentVM
    {
        public DepartmentVM(Department src)
        {
            Id = src.Id;
            Address = src.Address;
            EmployeeId = src.EmployeeId;
            Name = src.Name;
        }

        public Guid Id { get; set; }
        public string Address { get; set; }
        public string EmployeeId { get; set; }
        public string Name { get; set; }
    }
}
