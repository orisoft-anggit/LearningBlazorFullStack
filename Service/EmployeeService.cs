using System.Collections.Generic;
using System.Net.Http;
namespace BlazorFrontEnd.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            httpClient = httpClient;
        }

        public async Task<List<EmployeeDTO>>GetAllEmployee()
        {
            return await _httpClient.GetJsonAsync<Employee[]>("api/employee");
        }
    }
}