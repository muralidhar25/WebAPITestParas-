using ParasMachineTestWebAPI.Models;
using ParasMachineTestWebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParasMachineTestWebAPI.Utility.Profile
{
    public class ApplicationProfile :AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<EmployeeViewModel, Employee>();
        }
    }
}
