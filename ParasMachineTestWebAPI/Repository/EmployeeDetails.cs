using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ParasMachineTestWebAPI.Models;
using ParasMachineTestWebAPI.Services;
using ParasMachineTestWebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParasMachineTestWebAPI.Repository
{
    public class EmployeeDetails : IEmployeeDetails
    {
        private readonly EmployeeDBContext _employeeDBContext;
        private readonly IMapper _mapper;
        public EmployeeDetails(EmployeeDBContext employeeDBContext,IMapper mapper)
        {
            _employeeDBContext = employeeDBContext;
            _mapper = mapper;
        }
        public List<Employee> GetAll()
        {
            try
            {
                var employee =  _employeeDBContext.Employees.ToList();
                return employee;
            }
            catch (Exception ex)
            {
                List<Employee> employee=null;
                return employee.ToList();
            }
            
        }
        public  bool SaveEmployee(EmployeeViewModel employeeViewModel)
        {
            try
            {
                Employee employee = new Employee();
                _mapper.Map(employeeViewModel, employee);
                _employeeDBContext.Employees.Add(employee);
                _employeeDBContext.SaveChanges();
                return true;
            }
           catch(Exception ex)
            {
                return false;
            }

        }
    }
}
