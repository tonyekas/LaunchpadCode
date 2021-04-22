using LaunchpadCodeChallenge.Models.Entitities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.App.Service.Interface
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<IList<Employee>> ListAll();
    }
}
