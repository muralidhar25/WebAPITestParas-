using ParasMachineTestWebAPI.Models;
using ParasMachineTestWebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParasMachineTestWebAPI.Services
{
    public interface IEmployeeDetails
    {
         List<Employee> GetAll();
        bool SaveEmployee(EmployeeViewModel employeeViewModel);
    }
}
