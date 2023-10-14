using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFrontEnd.Service
{
    public class IEmployeeService
    {
        Task<List<EmployeeDTO>>GetAllEmployee();
    }
}