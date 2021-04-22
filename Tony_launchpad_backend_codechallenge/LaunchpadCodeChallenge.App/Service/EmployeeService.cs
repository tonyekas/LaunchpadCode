using LaunchpadCodeChallenge.App.Service.Interface;
using LaunchpadCodeChallenge.Models.Entitities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.App.Service
{
    public class EmployeeService : IEmployeeService
    {
        public async Task<IEnumerable<Employee>> GetAll()
        {
            var employee = new List<Employee>
            {
                new Employee{
                Address = "123 New street Calgary Ab",
                FirstName = "Tony",
                LastName = "Onyek",
                JobTitle = "Manager",
                Id = Guid.NewGuid()},
                new Employee
                {
                Address = "234 Hill Ave Calgary Ab",
                FirstName = "Emeka",
                LastName = "John",
                JobTitle = "Assist",
                Id = Guid.NewGuid()
                },
                new Employee
                {
                Address = "987 Village Square Calgary Ab",
                FirstName = "Mann",
                LastName = "Kens",
                JobTitle = "Officer",
                Id = Guid.NewGuid()
                }
            };
            return employee;
        }

        public async Task<IList<Employee>> ListAll()
        {
            var employee = new List<Employee>
            {
                new Employee{
                Address = "563 river road Calgary Ab",
                FirstName = "Pence",
                LastName = "Bill",
                JobTitle = "CEO",
                Id = Guid.NewGuid()},
                new Employee
                {
                Address = "5676 Evanston Edmonton, Ab",
                FirstName = "Paul",
                LastName = "John",
                JobTitle = "Controller",
                Id = Guid.NewGuid()
                },
                new Employee
                {
                Address = "866 Mill Village Calgary Ab",
                FirstName = "Edu",
                LastName = "Wills",
                JobTitle = "Caster",
                Id = Guid.NewGuid()
                }
            };
            return employee;
        }
    }
}
